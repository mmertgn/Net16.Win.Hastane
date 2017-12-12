using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Ninject;

namespace Hastane.PL
{
    public partial class FormHastaKabul : Form
    {
        private readonly IHastaKabulRepository _hastaKabulRepo;
        private readonly IHastaKabulService _hastaKabulService;
        private readonly IRandevuService _randevuService;
        private readonly IRandevuRepository _randevuRepo;
        private Randevular SecilenHasta;
        public FormHastaKabul()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _hastaKabulRepo = container.Get<IHastaKabulRepository>();
            _hastaKabulService = container.Get<IHastaKabulService>();
            _randevuService = container.Get<IRandevuService>();
            _randevuRepo = container.Get<IRandevuRepository>();
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
            var result = _randevuService.Edit(kabul);

            var model2 = new HastaKabul
            {
                HastaID = SecilenHasta.HastaID,
                PersonelID = SecilenHasta.PersonelID,
                GelisTarihi = SecilenHasta.Tarih,
                KlinikID = (int) SecilenHasta.Personeller.KlinikID,
                TahlilYapildiMi = true
            };
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
