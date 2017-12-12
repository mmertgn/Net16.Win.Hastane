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
using Hastane.PL.DependecyResolver;
using Ninject;

namespace Hastane.PL
{
    public partial class FormOdemeIslemleri : Form
    {
        #region NinjectDeğişkenler
        private readonly IHastaKabulService _hastaKabulService;
        private readonly IHastaHizmetHareketService _hastaHizmetHareketService;
        private readonly IOdemeRepository _odemeRepository;

        private HastaKabul _secilenHasta;
        private double _genelToplam;
        private const double Kdv = 0.08;

        #endregion
        public FormOdemeIslemleri()
        {
            var container = NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _hastaKabulService = container.Get<IHastaKabulService>();
            _hastaHizmetHareketService = container.Get<IHastaHizmetHareketService>();
            _odemeRepository = container.Get<IOdemeRepository>();
            InitializeComponent();
        }
        
        
        private void FormOdemeIslemleri_Load(object sender, EventArgs e)
        {
            RandevuluHastalarDoldur();
        }
        private void txtAdSoyadAra_OnValueChanged(object sender, EventArgs e)
        {
            var model = _hastaKabulService.DoktorRandevularıDoldurAra(txtAdSoyadAra.Text, txtTelefonAra.Text, TxtTCNoAra.Text);
            dgvHastaKabuller.DataSource = model;
            RandevuDataGridViewDuzenle();
        }
        private void HastaHizmetHareketlerDoldur()
        {
            lvHizmetHareketler.Items.Clear();
            if (_secilenHasta == null) return;
            var model = _hastaHizmetHareketService.HizmetHareketListWithSorgu(x => x.KabulID == _secilenHasta.KabulID);

            foreach (var item in model)
            {
                var lvi = new ListViewItem();
                lvi.Text = item.HareketID.ToString();
                lvi.SubItems.Add(item.Hizmetler.HizmetAdi);
                lvi.SubItems.Add($"{item.Tutar:c}");
                _genelToplam = _genelToplam + Convert.ToDouble(item.Tutar);
                lvHizmetHareketler.Items.Add(lvi);
            }
        }
        private void dgvRandevular_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _genelToplam = 0;
            try
            {
                var _kabulId = dgvHastaKabuller.CurrentRow.Cells[0].Value;
                _secilenHasta = _hastaKabulService.GetHastaKabulById(Convert.ToInt32(_kabulId));
                txtKurum.Text = _secilenHasta.Hastalar.Kurumlar.KurumAd;
                HastaHizmetHareketlerDoldur();
                _genelToplam = (double)(_genelToplam - (_genelToplam * _secilenHasta.Hastalar.Kurumlar.Iskonto/100));
                _genelToplam = _genelToplam + (_genelToplam * Kdv);
                txtKDV.Text = "%" + Kdv;
                txtGenelToplam.Text = ($"{_genelToplam:c}");
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private void RandevuluHastalarDoldur()
        {
            //Sorgu Login olan doktorun randevularını göstercek şekilde düzenlenecek
            var model = _hastaKabulService.DoktorRandevularıDoldur();
            dgvHastaKabuller.DataSource = model;
            RandevuDataGridViewDuzenle();
        }
        private void RandevuDataGridViewDuzenle()
        {
            dgvHastaKabuller.Columns[0].Visible = false;
            dgvHastaKabuller.Columns[1].Visible = false;
            dgvHastaKabuller.Columns[2].Visible = false;
            dgvHastaKabuller.Columns[3].HeaderText = "Ad Soyad";
            dgvHastaKabuller.Columns[4].HeaderText = "TC Kimlik No";
            dgvHastaKabuller.Columns[5].HeaderText = "Cep Telefonu";
            dgvHastaKabuller.Columns[6].HeaderText = "Randevu Tarihi";
            dgvHastaKabuller.Columns[7].HeaderText = "Hasta Yaşı";
            dgvHastaKabuller.Columns[8].HeaderText = "Kan Grubu";
            dgvHastaKabuller.Columns[9].HeaderText = "Sigorta Kurumu";
            dgvHastaKabuller.Columns[10].HeaderText = "Klinik Adı";
            dgvHastaKabuller.Columns[11].HeaderText = "Doktor Adı";
            for (int i = 0; i < dgvHastaKabuller.Columns.Count; i++)
            {
                dgvHastaKabuller.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnFaturaYazdir_Click(object sender, EventArgs e)
        {
            var frm = new FormFatura(_secilenHasta,_genelToplam);
            frm.Show();
        }

        private void btnIslemiBitir_Click(object sender, EventArgs e)
        {
            if (_secilenHasta==null)return;

            var Secim = MessageBox.Show("Ödemeyi Onaylıyor musunuz_?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim != DialogResult.Yes) return;
            _secilenHasta.CikisTarihi = DateTime.Now;
            _hastaKabulService.Edit(_secilenHasta);
            var model = new Odemeler
            {
                Tarih = DateTime.Now,
                KabulID = _secilenHasta.KabulID,
                OdemeTuru = "Nakit",
                Toplam = Convert.ToDecimal(_genelToplam),
                Indirim = Convert.ToDecimal((_genelToplam * _secilenHasta.Hastalar.Kurumlar.Iskonto / 100)),
                Aciklama = "-"
            };
            _odemeRepository.Add(model);

            MessageBox.Show("Hasta Ödemesi ve Hasta Çıkışı Başarıyla Gerçekleştirildi.", "İşlem Gerçekleştirildi!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            RandevuluHastalarDoldur();
        }
    }
}
