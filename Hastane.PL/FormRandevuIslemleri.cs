using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Ninject;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hastane.PL
{
    public partial class FormRandevuIslemleri : Form
    {
        #region NinjectDeğişkenler
        private readonly IHastaRepository _hastaRepository;
        private readonly IHastaService _hastaService;
        private readonly IILRepository _ilRepository;
        private readonly IIlceRepository _ilceRepository;
        private readonly IKurumRepository _kurumRepository;
        private readonly IPersonelService _personelService;
        private readonly IPersonelRepository _personelRepository;
        private readonly IKlinikRepository _klinikRepository;
        private readonly IRandevuService _randevuService;
        #endregion

        private int _secilenHastaId;
        private Hastalar _secilenHasta;
        public FormRandevuIslemleri()
        {
            #region NinjectAtamalar
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _hastaRepository = container.Get<IHastaRepository>();
            _hastaService = container.Get<IHastaService>();
            _ilceRepository = container.Get<IIlceRepository>();
            _ilRepository = container.Get<IILRepository>();
            _kurumRepository = container.Get<IKurumRepository>();
            _personelService = container.Get<IPersonelService>();
            _klinikRepository = container.Get<IKlinikRepository>();
            _randevuService = container.Get<IRandevuService>();
            _personelRepository = container.Get<IPersonelRepository>();
            #endregion
            InitializeComponent();
        }

        private void FormRandevuIslemleri_Load(object sender, EventArgs e)
        {
            HastaListesiDoldur();
            GuncelTarihleriDoldur();
            IlDoldur();
            KurumDoldur();
            KlinikDoldur();
            DoktorDoldur();
            RandevuTablosuDoldur();
        }

        private void GuncelTarihleriDoldur()
        {
            dtpRandevuTarih.Value = DateTime.Now.Date;
        }

        private void KurumDoldur()
        {
            var model = _kurumRepository.GetList();
            model.ForEach(item =>
            {
                cbKurum.AddItem(item.KurumAd);
            }
            );
            cbKurum.selectedIndex = 0;
        }

        private void HastaListesiDoldur()
        {
            var model = _hastaService.HastaBilgileriDoldur();
            dgvHastalar.DataSource = model;
            HastaListesiDataGridViewDuzenle();
        }
        private void txtAdSoyadAra_OnValueChanged(object sender, EventArgs e)
        {
            var model =
                _hastaService.HastaBilgileriDoldurAra(txtAdSoyadAra.Text, txtTelefonAra.Text, txtTCKimlikNoAra.Text);
            dgvHastalar.DataSource = model;
            HastaListesiDataGridViewDuzenle();
        }

        private void HastaListesiDataGridViewDuzenle()
        {
            dgvHastalar.Columns[0].Visible = false;
            dgvHastalar.Columns[1].HeaderText = "Ad Soyad";
            dgvHastalar.Columns[2].HeaderText = "TC Kimlik No";
            dgvHastalar.Columns[3].HeaderText = "Cep Telefonu";
            dgvHastalar.Columns[4].HeaderText = "Sigorta Kurumu";
            for (var i = 0; i < dgvHastalar.Columns.Count; i++)
            {
                dgvHastalar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        #region İlveİlçeListeleme
        private void IlDoldur()
        {
            var model = _ilRepository.GetList();
            model.ForEach(item =>
            {
                cbil.AddItem(item.sehir);
            }
            );
            cbil.selectedIndex = 0;
        }
        private void cbil_onItemSelected(object sender, EventArgs e)
        {
            cbIlce.Clear();
            var il = _ilRepository.ilGetir(cbil.selectedValue).FirstOrDefault();
            var model = _ilceRepository.GetList(x => x.sehir == il.id);
            model.ForEach(item =>
            {
                cbIlce.AddItem(item.ilce);
            }
            );
            cbIlce.selectedIndex = 0;
        }
        #endregion

        private void btnHastaKayıt_Click(object sender, EventArgs e)
        {
            var kurum = _kurumRepository.KurumGetir(cbKurum.selectedValue).FirstOrDefault(); //Seçilen Kurumun idsini getirir.

            if (kurum != null)
            {
                var model = new Hastalar
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    TCKimlikNo = txtTCKimlikNo.Text,
                    Cinsiyet = cbCinsiyet.selectedValue,
                    CepTel = txtCepTelefonu.Text,
                    EvTel = txtEvTelefonu.Text,
                    KanGrubu = txtKanGrubu.Text,
                    DogumTarihi = dtpDogumTarihi.Value.Date,
                    il = cbil.selectedValue,
                    Ilce = cbIlce.selectedValue,
                    KurumID = kurum.KurumID,
                    Adres = txtAdres.Text
                };

                var result = _hastaService.Create(model);
                if (result.IsSucceed)
                {
                    MessageBox.Show(result.SuccessMessage, @"İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.ErrorMessage), @"İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            HastaListesiDoldur();
            FormuTemizle();
        }

        private void FormuTemizle()
        {
            _secilenHasta = null;
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTCKimlikNo.Text = "";
            txtCepTelefonu.Text = "";
            txtEvTelefonu.Text = "";
            txtAdres.Text = "";
            cbil.selectedIndex = 0;
            cbKurum.selectedIndex = 0;
            txtKanGrubu.Text = "";

            txtAdSoyadRandevu.Text = "";
            txtRandevuSaati.Text = "";
        }

        private void dgvHastalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _secilenHastaId = Convert.ToInt32(dgvHastalar.SelectedRows[0].Cells[0].Value);
            if (_secilenHastaId == 0) return;
            _secilenHasta = _hastaService.GetHastaById(_secilenHastaId);
            txtAd.Text = _secilenHasta.Ad;
            txtSoyad.Text = _secilenHasta.Soyad;
            txtTCKimlikNo.Text = _secilenHasta.TCKimlikNo;
            cbCinsiyet.Text = _secilenHasta.Cinsiyet;
            txtCepTelefonu.Text = _secilenHasta.CepTel;
            txtEvTelefonu.Text = _secilenHasta.EvTel;
            txtKanGrubu.Text = _secilenHasta.KanGrubu;
            dtpDogumTarihi.Value = (DateTime)_secilenHasta.DogumTarihi;
            cbil.Text = _secilenHasta.il;
            cbIlce.Text = _secilenHasta.Ilce;
            cbKurum.Text = _secilenHasta.Kurumlar.KurumAd;
            txtAdres.Text = _secilenHasta.Adres;

            txtAdSoyadRandevu.Text = _secilenHasta.Ad + " " + _secilenHasta.Soyad;
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            var kurum = _kurumRepository.KurumGetir(cbKurum.selectedValue).FirstOrDefault(); //Seçilen Kurumun idsini getirir.
            if (_secilenHasta != null)
            {
                _secilenHasta.Ad = txtAd.Text;
                _secilenHasta.Soyad = txtSoyad.Text;
                _secilenHasta.TCKimlikNo = txtTCKimlikNo.Text;
                _secilenHasta.Cinsiyet = cbCinsiyet.Text;
                _secilenHasta.CepTel = txtCepTelefonu.Text;
                _secilenHasta.EvTel = txtEvTelefonu.Text;
                _secilenHasta.KanGrubu = txtKanGrubu.Text;
                _secilenHasta.DogumTarihi = dtpDogumTarihi.Value;
                _secilenHasta.il = cbil.Text;
                _secilenHasta.Ilce = cbIlce.Text;
                _secilenHasta.KurumID = kurum.KurumID;
                _secilenHasta.Adres = txtAdres.Text;

                var result = _hastaService.Edit(_secilenHasta);
                if (result.IsSucceed)
                {
                    MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                HastaListesiDoldur();
            }
        }

        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            if (_secilenHasta != null)
            {
                var result = _hastaService.Delete(_secilenHasta.HastaID);
                if (result.IsSucceed)
                {
                    MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                HastaListesiDoldur();
            }
        }

        #region Randevu İşlemleri
        private void RandevuTablosuDoldur()
        {
            try
            {
                var randevular = _randevuService.DoktoraAitRandevular(cbDoktor.selectedValue, dtpRandevuTarih.Value);
                foreach (var randevu in randevular)
                {
                    #region TabloSorguları
                    if (lbl9.Text == randevu) { lbl9.BackColor = Color.Transparent; lbl9.Enabled = false; }
                    else if (lbl920.Text == randevu) { lbl920.BackColor = Color.Transparent; lbl920.Enabled = false; }
                    else if (lbl940.Text == randevu) { lbl940.BackColor = Color.Transparent; lbl940.Enabled = false; }
                    else if (lbl10.Text == randevu) { lbl10.BackColor = Color.Transparent; lbl10.Enabled = false; }
                    else if (lbl1020.Text == randevu) { lbl1020.BackColor = Color.Transparent; lbl1020.Enabled = false; }
                    else if (lbl1040.Text == randevu) { lbl1040.BackColor = Color.Transparent; lbl1040.Enabled = false; }
                    else if (lbl11.Text == randevu) { lbl11.BackColor = Color.Transparent; lbl11.Enabled = false; }
                    else if (lbl1120.Text == randevu) { lbl1120.BackColor = Color.Transparent; lbl1120.Enabled = false; }
                    else if (lbl1140.Text == randevu) { lbl1140.BackColor = Color.Transparent; lbl1140.Enabled = false; }
                    else if (lbl12.Text == randevu) { lbl12.BackColor = Color.Transparent; lbl12.Enabled = false; }
                    else if (lbl1220.Text == randevu) { lbl1220.BackColor = Color.Transparent; lbl1220.Enabled = false; }
                    else if (lbl1240.Text == randevu) { lbl1240.BackColor = Color.Transparent; lbl1240.Enabled = false; }
                    else if (lbl13.Text == randevu) { lbl13.BackColor = Color.Transparent; lbl13.Enabled = false; }
                    else if (lbl1320.Text == randevu) { lbl1320.BackColor = Color.Transparent; lbl1320.Enabled = false; }
                    else if (lbl1340.Text == randevu) { lbl1340.BackColor = Color.Transparent; lbl1340.Enabled = false; }
                    else if (lbl14.Text == randevu) { lbl14.BackColor = Color.Transparent; lbl14.Enabled = false; }
                    else if (lbl1420.Text == randevu) { lbl1420.BackColor = Color.Transparent; lbl1420.Enabled = false; }
                    else if (lbl1440.Text == randevu) { lbl1440.BackColor = Color.Transparent; lbl1440.Enabled = false; }
                    else if (lbl15.Text == randevu) { lbl15.BackColor = Color.Transparent; lbl15.Enabled = false; }
                    else if (lbl1520.Text == randevu) { lbl1520.BackColor = Color.Transparent; lbl1520.Enabled = false; }
                    else if (lbl1540.Text == randevu) { lbl1540.BackColor = Color.Transparent; lbl1540.Enabled = false; }
                    else if (lbl16.Text == randevu) { lbl16.BackColor = Color.Transparent; lbl16.Enabled = false; }
                    else if (lbl1620.Text == randevu) { lbl1620.BackColor = Color.Transparent; lbl1620.Enabled = false; }
                    else if (lbl1640.Text == randevu) { lbl1640.BackColor = Color.Transparent; lbl1640.Enabled = false; }
                    #endregion
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void DoktorDoldur()
        {
            try
            {
                cbDoktor.Clear();
                var model = _personelService.DoktorDoldurByKlinikFromRandevu(cbKlinik.selectedValue);
                model.ForEach(item =>
                {
                    cbDoktor.AddItem(item.Unvanlar.PersonelUnvan + " " + item.Ad + " " + item.Soyad);
                }
                );
                cbDoktor.selectedIndex = 0;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void KlinikDoldur()
        {
            var model = _klinikRepository.GetList();
            model.ForEach(item =>
            {
                cbKlinik.AddItem(item.KlinikAd);
            }
            );
            cbKlinik.selectedIndex = 0;
        }

        private void RandevuSaatSec(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            txtRandevuSaati.Text = lbl.Text;
        }
        private void btnRandevuKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var randevu = new Randevular
                {
                    HastaID = _secilenHasta.HastaID,
                    Tarih = dtpRandevuTarih.Value,
                    Saat = txtRandevuSaati.Text,
                    PersonelID = _personelRepository
                        .GetList(x => (x.Unvanlar.PersonelUnvan + " " + x.Ad + " " + x.Soyad) == cbDoktor.selectedValue)
                        .Select(x => x.PersonelID)
                        .FirstOrDefault(),
                    Geldimi = false
                };
                var result = _randevuService.Create(randevu);
                if (result.IsSucceed)
                {
                    MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RandevuTablosuTemizle();
                RandevuTablosuDoldur();
                FormuTemizle();
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private void RandevuTablosuTemizle()
        {
            lbl9.ForeColor = Color.White; lbl9.BackColor = Color.FromArgb(33, 43, 52); lbl9.Enabled = true;
            lbl920.ForeColor = Color.White; lbl920.BackColor = Color.FromArgb(33, 43, 52); lbl920.Enabled = true;
            lbl940.ForeColor = Color.White; lbl940.BackColor = Color.FromArgb(33, 43, 52); lbl940.Enabled = true;
            lbl10.ForeColor = Color.White; lbl10.BackColor = Color.FromArgb(33, 43, 52); lbl10.Enabled = true;
            lbl1020.ForeColor = Color.White; lbl1020.BackColor = Color.FromArgb(33, 43, 52); lbl1020.Enabled = true;
            lbl1040.ForeColor = Color.White; lbl1040.BackColor = Color.FromArgb(33, 43, 52); lbl1040.Enabled = true;
            lbl11.ForeColor = Color.White; lbl11.BackColor = Color.FromArgb(33, 43, 52); lbl11.Enabled = true;
            lbl1120.ForeColor = Color.White; lbl1120.BackColor = Color.FromArgb(33, 43, 52); lbl1120.Enabled = true;
            lbl1140.ForeColor = Color.White; lbl1140.BackColor = Color.FromArgb(33, 43, 52); lbl1140.Enabled = true;
            lbl12.ForeColor = Color.White; lbl12.BackColor = Color.FromArgb(33, 43, 52); lbl12.Enabled = true;
            lbl1220.ForeColor = Color.White; lbl1220.BackColor = Color.FromArgb(33, 43, 52); lbl1220.Enabled = true;
            lbl1240.ForeColor = Color.White; lbl1240.BackColor = Color.FromArgb(33, 43, 52); lbl1240.Enabled = true;
            lbl13.ForeColor = Color.White; lbl13.BackColor = Color.FromArgb(33, 43, 52); lbl13.Enabled = true;
            lbl1320.ForeColor = Color.White; lbl1320.BackColor = Color.FromArgb(33, 43, 52); lbl1320.Enabled = true;
            lbl1340.ForeColor = Color.White; lbl1340.BackColor = Color.FromArgb(33, 43, 52); lbl1340.Enabled = true;
            lbl14.ForeColor = Color.White; lbl14.BackColor = Color.FromArgb(33, 43, 52); lbl14.Enabled = true;
            lbl1420.ForeColor = Color.White; lbl1420.BackColor = Color.FromArgb(33, 43, 52); lbl1420.Enabled = true;
            lbl1440.ForeColor = Color.White; lbl1440.BackColor = Color.FromArgb(33, 43, 52); lbl1440.Enabled = true;
            lbl15.ForeColor = Color.White; lbl15.BackColor = Color.FromArgb(33, 43, 52); lbl15.Enabled = true;
            lbl1520.ForeColor = Color.White; lbl1520.BackColor = Color.FromArgb(33, 43, 52); lbl1520.Enabled = true;
            lbl1540.ForeColor = Color.White; lbl1540.BackColor = Color.FromArgb(33, 43, 52); lbl1540.Enabled = true;
            lbl16.ForeColor = Color.White; lbl16.BackColor = Color.FromArgb(33, 43, 52); lbl16.Enabled = true;
            lbl1620.ForeColor = Color.White; lbl1620.BackColor = Color.FromArgb(33, 43, 52); lbl1620.Enabled = true;
            lbl1640.ForeColor = Color.White; lbl1640.BackColor = Color.FromArgb(33, 43, 52); lbl1640.Enabled = true;
        }
        private void cbDoktor_onItemSelected(object sender, EventArgs e)
        {
            RandevuTablosuTemizle();
            RandevuTablosuDoldur();

        }

        private void dtpRandevuTarih_onValueChanged(object sender, EventArgs e)
        {
            RandevuTablosuTemizle();
            RandevuTablosuDoldur();
        }
        private void cbKlinik_onItemSelected(object sender, EventArgs e)
        {
            DoktorDoldur();
        }
        #endregion

    }
}
