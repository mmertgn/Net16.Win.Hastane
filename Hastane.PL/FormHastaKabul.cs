using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Ninject;
using System;
using System.Windows.Forms;

namespace Hastane.PL
{
    public partial class FormHastaKabul : Form
    {
        private readonly IHastaKabulService _hastaKabulService;
        private readonly IRandevuService _randevuService;
        private Randevular SecilenHasta;
        public FormHastaKabul()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _hastaKabulService = container.Get<IHastaKabulService>();
            _randevuService = container.Get<IRandevuService>();
            InitializeComponent();
        }

        private void FormHastaKabul_Load(object sender, EventArgs e)
        {
            RandevuListele();
        }

        private void RandevuListele()
        {
            var model = _randevuService.RandevuListele();
            dgvRandevuListesi.DataSource = model;
            RandevuListesiAyrıntı();
        }
        private void RandevuListesiAyrıntı()
        {
            dgvRandevuListesi.Columns[0].Visible = false;
            dgvRandevuListesi.Columns[1].Visible = false;
            dgvRandevuListesi.Columns[2].Visible = false;
            dgvRandevuListesi.Columns[9].Visible = false;
        }

        private void dgvRandevuListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var _randevuID = dgvRandevuListesi.CurrentRow.Cells[0].Value;
                SecilenHasta = _randevuService.GetRandevuById(Convert.ToInt32(_randevuID));
                txtHastaAdSoyad.Text = SecilenHasta.Hastalar.Ad + " " + SecilenHasta.Hastalar.Soyad;
                txtTCKNO.Text = SecilenHasta.Hastalar.TCKimlikNo;
                txtKlinik.Text = SecilenHasta.Personeller.Klinikler.KlinikAd;
                txtDoktor.Text = SecilenHasta.Personeller.Ad + " " + SecilenHasta.Personeller.Soyad;
                txtRandevuTarihi.Text = SecilenHasta.Tarih.ToShortDateString();
            }
            catch (Exception ex)
            {
                var hata = ex.Message;
            }
        }

        private void btnHastaKabulKaydet_Click(object sender, EventArgs e)
        {
            if (SecilenHasta == null) return;
            var kabul = _randevuService.GetRandevuById(SecilenHasta.RandevuID);

            kabul.Geldimi = true;

            DateTime tarih = TarihAyarla();
            var model2 = new HastaKabul
            {
                HastaID = SecilenHasta.HastaID,
                PersonelID = SecilenHasta.PersonelID,
                GelisTarihi = tarih,
                KlinikID = (int)SecilenHasta.Personeller.KlinikID,
                TahlilYapildiMi = true
            };
            var result = _randevuService.Edit(kabul);
            result = _hastaKabulService.Create(model2);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Temizle();
            RandevuListele();
        }

        private DateTime TarihAyarla()
        {
            var dizi = SecilenHasta.Saat.Split(':');
            var t2 = new DateTime(SecilenHasta.Tarih.Year, SecilenHasta.Tarih.Month, SecilenHasta.Tarih.Day, Convert.ToInt32(dizi[0]), Convert.ToInt32(dizi[1]), 0);
            return t2;
        }

        private void Temizle()
        {
            txtHastaAdSoyad.Text = "";
            txtDoktor.Text = "";
            txtKlinik.Text = "";
            txtRandevuTarihi.Text = "";
            txtTCKNO.Text = "";
        }

        private void txtAdSoyadAra_OnValueChanged(object sender, EventArgs e)
        {
            var model = _randevuService.RandevuListesiAra(txtAdSoyadAra.Text, txtTCKNOAra.Text);
            dgvRandevuListesi.DataSource = model;
            RandevuListesiAyrıntı();
        }
    }
}
