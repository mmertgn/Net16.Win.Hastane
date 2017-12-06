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
    public partial class FormRandevuIslemleri : Form
    {
        private readonly IHastaRepository _hastaRepository;
        private readonly IHastaService _hastaService;
        private readonly IILRepository _ilRepository;
        private readonly IIlceRepository _ilceRepository;
        private readonly IKurumRepository _kurumRepository;
        private readonly IPersonelService _personelService;
        private readonly IKlinikRepository _klinikRepository;
        private readonly IRandevuService _randevuService;

        private int _secilenHastaId;
        private Hastalar SecilenHasta;
        public FormRandevuIslemleri()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _hastaRepository = container.Get<IHastaRepository>();
            _hastaService = container.Get<IHastaService>();
            _ilceRepository = container.Get<IIlceRepository>();
            _ilRepository = container.Get<IILRepository>();
            _kurumRepository = container.Get<IKurumRepository>();
            _personelService = container.Get<IPersonelService>();
            _klinikRepository = container.Get<IKlinikRepository>();
            _randevuService = container.Get<IRandevuService>();

            InitializeComponent();
        }

        private void FormRandevuIslemleri_Load(object sender, EventArgs e)
        {
            HastaListesiDoldur();
            IlDoldur();
            KurumDoldur();
            KlinikDoldur();
            DoktorDoldur();
            RandevuTablosuDoldur();

        }

        private void RandevuTablosuDoldur()
        {
            try
            {
                var randevular = _randevuService.DoktoraAitRandevular(cbDoktor.selectedValue,dtpRandevuTarih.Value);
                foreach (var randevu in randevular)
                {
                    #region TabloSorguları
                    if (lbl9.Text == randevu) { lbl9.BackColor = Color.FromArgb(33, 43, 52); lbl9.ForeColor = Color.White; }
                    else if (lbl920.Text == randevu) { lbl920.BackColor = Color.FromArgb(33, 43, 52); lbl920.ForeColor = Color.White; }
                    else if (lbl940.Text == randevu) { lbl940.BackColor = Color.FromArgb(33, 43, 52); lbl940.ForeColor = Color.White; }
                    else if (lbl10.Text == randevu) { lbl10.BackColor = Color.FromArgb(33, 43, 52); lbl10.ForeColor = Color.White; }
                    else if (lbl1020.Text == randevu) { lbl1020.BackColor = Color.FromArgb(33, 43, 52); lbl1020.ForeColor = Color.White; }
                    else if (lbl1040.Text == randevu) { lbl1040.BackColor = Color.FromArgb(33, 43, 52); lbl1040.ForeColor = Color.White; }
                    else if (lbl11.Text == randevu) { lbl11.BackColor = Color.FromArgb(33, 43, 52); lbl11.ForeColor = Color.White; }
                    else if (lbl1120.Text == randevu) { lbl1120.BackColor = Color.FromArgb(33, 43, 52); lbl1120.ForeColor = Color.White; }
                    else if (lbl1140.Text == randevu) { lbl1140.BackColor = Color.FromArgb(33, 43, 52); lbl1140.ForeColor = Color.White; }
                    else if (lbl12.Text == randevu) { lbl12.BackColor = Color.FromArgb(33, 43, 52); lbl12.ForeColor = Color.White; }
                    else if (lbl13.Text == randevu) { lbl13.BackColor = Color.FromArgb(33, 43, 52); lbl13.ForeColor = Color.White; }
                    else if (lbl1320.Text == randevu) { lbl1320.BackColor = Color.FromArgb(33, 43, 52); lbl1320.ForeColor = Color.White; }
                    else if (lbl1340.Text == randevu) { lbl1340.BackColor = Color.FromArgb(33, 43, 52); lbl1340.ForeColor = Color.White; }
                    else if (lbl14.Text == randevu) { lbl14.BackColor = Color.FromArgb(33, 43, 52); lbl14.ForeColor = Color.White; }
                    else if (lbl1420.Text == randevu) { lbl1420.BackColor = Color.FromArgb(33, 43, 52); lbl1420.ForeColor = Color.White; }
                    else if (lbl1440.Text == randevu) { lbl1440.BackColor = Color.FromArgb(33, 43, 52); lbl1440.ForeColor = Color.White; }
                    else if (lbl15.Text == randevu) { lbl15.BackColor = Color.FromArgb(33, 43, 52); lbl15.ForeColor = Color.White; }
                    else if (lbl1520.Text == randevu) { lbl1520.BackColor = Color.FromArgb(33, 43, 52); lbl1520.ForeColor = Color.White; }
                    else if (lbl1540.Text == randevu) { lbl1540.BackColor = Color.FromArgb(33, 43, 52); lbl1540.ForeColor = Color.White; }
                    else if (lbl16.Text == randevu) { lbl16.BackColor = Color.FromArgb(33, 43, 52); lbl16.ForeColor = Color.White; }
                    else if (lbl1620.Text == randevu) { lbl1620.BackColor = Color.FromArgb(33, 43, 52); lbl1620.ForeColor = Color.White; }
                    else if (lbl1640.Text == randevu) { lbl1640.BackColor = Color.FromArgb(33, 43, 52); lbl1640.ForeColor = Color.White; }
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
            dgvHastalar.Rows.Clear();
            var sayac = 0;
            var model = _hastaRepository.GetList().Select(x => new
            {
                HastaId = x.HastaID,
                AdSoyad = x.Ad + " " + x.Soyad,
                TCNo = x.TCKimlikNo,
                Telefon = x.CepTel,
                Kurum = x.Kurumlar.KurumAd
            });
            foreach (var item in model)
            {
                dgvHastalar.Rows.Add();
                dgvHastalar.Rows[sayac].Cells[0].Value = item.HastaId;
                dgvHastalar.Rows[sayac].Cells[1].Value = item.AdSoyad;
                dgvHastalar.Rows[sayac].Cells[2].Value = item.TCNo;
                dgvHastalar.Rows[sayac].Cells[3].Value = item.Telefon;
                dgvHastalar.Rows[sayac].Cells[4].Value = item.Kurum;
                sayac++;
            }
        }
        private void txtAdSoyadAra_OnValueChanged(object sender, EventArgs e)
        {
            dgvHastalar.Rows.Clear();
            var sayac = 0;
            var model2 = _hastaService.HastaListWithSorgu(x => (x.Ad + " " + x.Soyad).Contains(txtAdSoyadAra.Text) && x.CepTel.Contains(txtTelefonAra.Text) && x.TCKimlikNo.Contains(txtTCKimlikNoAra.Text))
                .Select(x => new
                {
                    HastaId = x.HastaID,
                    AdSoyad = x.Ad + " " + x.Soyad,
                    TCNo = x.TCKimlikNo,
                    Telefon = x.CepTel,
                    Kurum = x.Kurumlar.KurumAd
                });
            foreach (var item in model2)
            {
                dgvHastalar.Rows.Add();
                dgvHastalar.Rows[sayac].Cells[0].Value = item.HastaId;
                dgvHastalar.Rows[sayac].Cells[1].Value = item.AdSoyad;
                dgvHastalar.Rows[sayac].Cells[2].Value = item.TCNo;
                dgvHastalar.Rows[sayac].Cells[3].Value = item.Telefon;
                dgvHastalar.Rows[sayac].Cells[4].Value = item.Kurum;
                sayac++;
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

            Hastalar model = new Hastalar
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
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HastaListesiDoldur();
        }

        private void dgvHastalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _secilenHastaId = Convert.ToInt32(dgvHastalar.SelectedRows[0].Cells[0].Value);
            if (_secilenHastaId == 0) return;
            SecilenHasta = _hastaService.GetHastaById(_secilenHastaId);
            txtAd.Text = SecilenHasta.Ad;
            txtSoyad.Text = SecilenHasta.Soyad;
            txtTCKimlikNo.Text = SecilenHasta.TCKimlikNo;
            cbCinsiyet.Text = SecilenHasta.Cinsiyet;
            txtCepTelefonu.Text = SecilenHasta.CepTel;
            txtEvTelefonu.Text = SecilenHasta.EvTel;
            txtKanGrubu.Text = SecilenHasta.KanGrubu;
            dtpDogumTarihi.Value = (DateTime)SecilenHasta.DogumTarihi;
            cbil.Text = SecilenHasta.il;
            cbIlce.Text = SecilenHasta.Ilce;
            cbKurum.Text = SecilenHasta.Kurumlar.KurumAd;
            txtAdres.Text = SecilenHasta.Adres;

            txtAdSoyadRandevu.Text = SecilenHasta.Ad + " " + SecilenHasta.Soyad;
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            var kurum = _kurumRepository.KurumGetir(cbKurum.selectedValue).FirstOrDefault(); //Seçilen Kurumun idsini getirir.
            if (SecilenHasta != null)
            {
                SecilenHasta.Ad = txtAd.Text;
                SecilenHasta.Soyad = txtSoyad.Text;
                SecilenHasta.TCKimlikNo = txtTCKimlikNo.Text;
                SecilenHasta.Cinsiyet = cbCinsiyet.Text;
                SecilenHasta.CepTel = txtCepTelefonu.Text;
                SecilenHasta.EvTel = txtEvTelefonu.Text;
                SecilenHasta.KanGrubu = txtKanGrubu.Text;
                SecilenHasta.DogumTarihi = dtpDogumTarihi.Value;
                SecilenHasta.il = cbil.Text;
                SecilenHasta.Ilce = cbIlce.Text;
                SecilenHasta.KurumID = kurum.KurumID;
                SecilenHasta.Adres = txtAdres.Text;

                var result = _hastaService.Edit(SecilenHasta);
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
            if (SecilenHasta != null)
            {
                var result = _hastaService.Delete(SecilenHasta.HastaID);
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

        private void cbKlinik_onItemSelected(object sender, EventArgs e)
        {
            DoktorDoldur();
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

        private void RandevuTablosuTemizle()
        {
            lbl9.BackColor = Color.Transparent; lbl9.ForeColor = Color.FromArgb(33, 43, 52);
            lbl920.BackColor = Color.Transparent; lbl920.ForeColor = Color.FromArgb(33, 43, 52);
            lbl940.BackColor = Color.Transparent; lbl940.ForeColor = Color.FromArgb(33, 43, 52);
            lbl10.BackColor = Color.Transparent; lbl10.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1020.BackColor = Color.Transparent; lbl1020.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1040.BackColor = Color.Transparent; lbl1040.ForeColor = Color.FromArgb(33, 43, 52);
            lbl11.BackColor = Color.Transparent; lbl11.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1120.BackColor = Color.Transparent; lbl1120.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1140.BackColor = Color.Transparent; lbl1140.ForeColor = Color.FromArgb(33, 43, 52);
            lbl12.BackColor = Color.Transparent; lbl12.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1220.BackColor = Color.Transparent; lbl1220.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1240.BackColor = Color.Transparent; lbl1240.ForeColor = Color.FromArgb(33, 43, 52);
            lbl13.BackColor = Color.Transparent; lbl13.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1320.BackColor = Color.Transparent; lbl1320.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1340.BackColor = Color.Transparent; lbl1340.ForeColor = Color.FromArgb(33, 43, 52);
            lbl14.BackColor = Color.Transparent; lbl14.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1420.BackColor = Color.Transparent; lbl1420.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1440.BackColor = Color.Transparent; lbl1440.ForeColor = Color.FromArgb(33, 43, 52);
            lbl15.BackColor = Color.Transparent; lbl15.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1520.BackColor = Color.Transparent; lbl1520.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1540.BackColor = Color.Transparent; lbl1540.ForeColor = Color.FromArgb(33, 43, 52);
            lbl16.BackColor = Color.Transparent; lbl16.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1620.BackColor = Color.Transparent; lbl1620.ForeColor = Color.FromArgb(33, 43, 52);
            lbl1640.BackColor = Color.Transparent; lbl1640.ForeColor = Color.FromArgb(33, 43, 52);
        }
    }
}
