using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.BLL.Models;
using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Ninject;

namespace Hastane.PL
{
    public partial class FormDoktorIslemleri : Form
    {
        #region NinjectDeğişkenler
        private readonly IHastaKabulRepository _hastaKabulRepository;
        private readonly IHastaKabulService _hastaKabulService;

        private HastaKabul SecilenHasta;

        #endregion
        public FormDoktorIslemleri()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _hastaKabulRepository = container.Get<IHastaKabulRepository>();
            _hastaKabulService = container.Get<IHastaKabulService>();
            InitializeComponent();
        }

        private void FormDoktorIslemleri_Load(object sender, EventArgs e)
        {
            RandevuluHastalarDoldur();
            GuncelTarihleriDoldur();
        }

        private void GuncelTarihleriDoldur()
        {
            dtpReceteTarih.Value = DateTime.Now.Date;
        }

        private void RandevuluHastalarDoldur()
        {
            //Sorgu Login olan doktorun randevularını göstercek şekilde düzenlenecek
            var model = _hastaKabulService.DoktorRandevularıDoldur();
            dgvRandevular.DataSource = model;
            RandevuDataGridViewDuzenle();
        }

        private void RandevuDataGridViewDuzenle()
        {
            dgvRandevular.Columns[0].Visible = false;
            dgvRandevular.Columns[1].Visible = false;
            dgvRandevular.Columns[2].Visible = false;
            dgvRandevular.Columns[3].HeaderText = "Ad Soyad";
            dgvRandevular.Columns[4].HeaderText = "TC Kimlik No";
            dgvRandevular.Columns[5].HeaderText = "Cep Telefonu";
            dgvRandevular.Columns[6].HeaderText = "Randevu Tarihi";
            dgvRandevular.Columns[7].HeaderText = "Hasta Yaşı";
            dgvRandevular.Columns[8].HeaderText = "Kan Grubu";
            dgvRandevular.Columns[9].HeaderText = "Sigorta Kurumu";
            dgvRandevular.Columns[10].HeaderText = "Klinik Adı";
            dgvRandevular.Columns[11].HeaderText = "Doktor Adı";
            for (int i = 0; i < dgvRandevular.Columns.Count; i++)
            {
                dgvRandevular.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void txtAdSoyadAra_OnValueChanged(object sender, EventArgs e)
        {
            var model = _hastaKabulService.DoktorRandevularıDoldurAra(txtAdSoyadAra.Text,txtTelefonAra.Text,txtTCKimlikNoAra.Text);
            dgvRandevular.DataSource = model;
            RandevuDataGridViewDuzenle();
        }

        private void dgvRandevular_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var _kabulId = dgvRandevular.CurrentRow.Cells[0].Value;
                SecilenHasta = _hastaKabulService.GetHastaKabulById(Convert.ToInt32(_kabulId));
                txtAd.Text = SecilenHasta.Hastalar.Ad + " " + SecilenHasta.Hastalar.Soyad;
                txtTCKimlikNo.Text = SecilenHasta.Hastalar.TCKimlikNo;
                txtKlinikAdi.Text = SecilenHasta.Personeller.Klinikler.KlinikAd;
                txtDoktorAdi.Text = SecilenHasta.Personeller.Ad + " " + SecilenHasta.Personeller.Soyad;
                txtKanGrubu.Text = SecilenHasta.Hastalar.KanGrubu;
                txtRandevuTarih.Text = SecilenHasta.GelisTarihi.ToShortDateString();
                txtRandevuSaat.Text = SecilenHasta.GelisTarihi.ToShortTimeString();
                txtSigortaKurumu.Text = SecilenHasta.Hastalar.Kurumlar.KurumAd;
                if (SecilenHasta.HastaSikayetleri.Aciklama != null)
                    txtHastaSikayeti.Text = SecilenHasta.HastaSikayetleri.Aciklama;
                //TahlilleriDoldur();
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
