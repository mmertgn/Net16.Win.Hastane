using System;
using System.Linq;
using System.Windows.Forms;
using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Hastane.PL.DependecyResolver;
using Ninject;

namespace Hastane.PL
{
    public partial class FormDoktorIslemleri : Form
    {
        #region NinjectDeğişkenler
        private readonly IHastaKabulRepository _hastaKabulRepository;
        private readonly IHastaKabulService _hastaKabulService;
        private readonly IHastaSikayetleriService _hastaSikayetleriService;
        private readonly ITeshisService _teshisService;
        private readonly IReceteService _receteService;
        private readonly IReceteDetayService _receteDetayService;
        private readonly IReceteDetayRepository _receteDetayRepository;
        private readonly IHizmetService _hizmetService;
        private readonly IHastaHizmetHareketService _hastaHizmetHareketService;
        private readonly IHastaHizmetHareketRepository _hastaHizmetHareketRepository;
        private readonly IHastaTahlilSonuclariService _hastaTahlilSonuclariService;

        private HastaKabul _secilenHasta;

        #endregion
        public FormDoktorIslemleri()
        {
            var container = NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _hastaKabulRepository = container.Get<IHastaKabulRepository>();
            _hastaKabulService = container.Get<IHastaKabulService>();
            _hastaSikayetleriService = container.Get<IHastaSikayetleriService>();
            _teshisService = container.Get<ITeshisService>();
            _receteService = container.Get<IReceteService>();
            _receteDetayService = container.Get<IReceteDetayService>();
            _receteDetayRepository = container.Get<IReceteDetayRepository>();
            _hizmetService = container.Get<IHizmetService>();
            _hastaHizmetHareketService = container.Get<IHastaHizmetHareketService>();
            _hastaHizmetHareketRepository = container.Get<IHastaHizmetHareketRepository>();
            _hastaTahlilSonuclariService = container.Get<IHastaTahlilSonuclariService>();

            InitializeComponent();
        }

        private void FormDoktorIslemleri_Load(object sender, EventArgs e)
        {
            RandevuluHastalarDoldur();
            GuncelTarihleriDoldur();
            HizmetleriDoldur();
        }

        private void HizmetleriDoldur()
        {
            cbHizmetler.Clear();
            if (_secilenHasta == null) return;
            var model = _hizmetService.HizmetListWithSorgu(x => x.KlinikID == _secilenHasta.KlinikID)
                .Select(x => (x.Klinikler.KlinikAd + "-" + x.HizmetAdi)).ToList();
            model.ForEach(item =>
                {
                    cbHizmetler.AddItem(item);
                }
            );
            cbHizmetler.selectedIndex = 0;
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
            var model = _hastaKabulService.DoktorRandevularıDoldurAra(txtAdSoyadAra.Text, txtTelefonAra.Text, txtTCKimlikNoAra.Text);
            dgvRandevular.DataSource = model;
            RandevuDataGridViewDuzenle();
        }

        private void dgvRandevular_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var _kabulId = dgvRandevular.CurrentRow.Cells[0].Value;
                _secilenHasta = _hastaKabulService.GetHastaKabulById(Convert.ToInt32(_kabulId));
                txtAd.Text = _secilenHasta.Hastalar.Ad + " " + _secilenHasta.Hastalar.Soyad;
                txtTCKimlikNo.Text = _secilenHasta.Hastalar.TCKimlikNo;
                txtKlinikAdi.Text = _secilenHasta.Personeller.Klinikler.KlinikAd;
                txtDoktorAdi.Text = _secilenHasta.Personeller.Ad + " " + _secilenHasta.Personeller.Soyad;
                txtKanGrubu.Text = _secilenHasta.Hastalar.KanGrubu;
                txtRandevuTarih.Text = _secilenHasta.GelisTarihi.ToShortDateString();
                txtRandevuSaat.Text = _secilenHasta.GelisTarihi.ToShortTimeString();
                txtSigortaKurumu.Text = _secilenHasta.Hastalar.Kurumlar.KurumAd;
                txtIstenenTahliller.Text = _secilenHasta.IstenenTahliller;

                var sikayet = _hastaSikayetleriService.GetHastaSikayetleriByKabulId(_secilenHasta.KabulID);
                txtHastaSikayeti.Text = sikayet != null ? sikayet.Aciklama : "";
                var teshis = _teshisService.GetTeshisByKabulId(_secilenHasta.KabulID);
                txtTeshis.Text = teshis != null ? teshis.Teshis : "";
                ReceteListesiDoldur();
                HizmetleriDoldur();
                HastaHizmetHareketlerDoldur();
                TahlilleriDoldur();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void TahlilleriDoldur()
        {
            cbTahliller.Clear();
            if (_secilenHasta == null) return;
            var model = _hastaTahlilSonuclariService.HizmetList().Select(x => x.TahlilAdi).Distinct().ToList();
            model.ForEach(item =>
                {
                    cbTahliller.AddItem(item);
                }
            );
            cbTahliller.selectedIndex = 0;
        }

        private void btnSikayetEkle_Click(object sender, EventArgs e)
        {
            if (_secilenHasta == null) return;
            var sikayet = new HastaSikayetleri
            {
                HastaID = _secilenHasta.HastaID,
                KabulID = _secilenHasta.KabulID,
                Aciklama = txtHastaSikayeti.Text,
                Tarih = _secilenHasta.GelisTarihi
            };

            var result = _hastaSikayetleriService.Create(sikayet);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSikayetGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenHasta == null) return;
            var sikayet = _hastaSikayetleriService.GetHastaSikayetleriByKabulId(_secilenHasta.KabulID);
            sikayet.Aciklama = txtHastaSikayeti.Text;
            var result = _hastaSikayetleriService.Edit(sikayet);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTeshisKoy_Click(object sender, EventArgs e)
        {

            if (_secilenHasta == null) return;
            var teshis = new Teshisler
            {
                Tarih = _secilenHasta.GelisTarihi,
                PersonelID = _secilenHasta.PersonelID,
                KabulID = _secilenHasta.KabulID,
                Teshis = txtTeshis.Text
            };
            var result = _teshisService.Create(teshis);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTeshisGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenHasta == null) return;
            var teshis = _teshisService.GetTeshisByKabulId(_secilenHasta.KabulID);
            teshis.Teshis = txtTeshis.Text;
            var result = _teshisService.Edit(teshis);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTahlilIste_Click(object sender, EventArgs e)
        {
            if (_secilenHasta == null) return;
            _secilenHasta.IstenenTahliller = txtIstenenTahliller.Text;
            _secilenHasta.TahlilYapildiMi = false;
            var result = _hastaKabulService.Edit(_secilenHasta);
            MessageBox.Show("Hastadan İstenen Tahliller Başarıyla Düzenlendi.", "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReceteOlustur_Click(object sender, EventArgs e)
        {
            if (_secilenHasta == null) return;
            var recete = new Receteler
            {
                Tarih = DateTime.Now,
                KabulID = _secilenHasta.KabulID,
                KurumID = (int)_secilenHasta.Hastalar.KurumID,
                PersonelID = _secilenHasta.PersonelID,
                HastaID = _secilenHasta.HastaID
            };
            var result = _receteService.Create(recete);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            if (_secilenHasta == null) return;
            var receteId = _receteService.GetReceteId(_secilenHasta.KabulID);
            try
            {
                var receteDetay = new ReceteDetay
                {
                    ReceteID = receteId,
                    İlacAd = txtIlacAdi.Text,
                    İlacKullanimSikligi = txtIlacKullanimSikligi.Text
                };
                var result = _receteDetayService.Create(receteDetay);
                if (result.IsSucceed)
                {
                    MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                // ignored
            }
            ReceteListesiDoldur();
        }

        private void ReceteListesiDoldur()
        {
            lvRecete.Items.Clear();
            if (_secilenHasta == null) return;
            var receteId = _receteService.GetReceteId(_secilenHasta.KabulID);
            var model = _receteDetayService.ReceteDetayListesi(receteId);

            foreach (var item in model)
            {
                var lvi = new ListViewItem();
                lvi.Text = item.IlacAd;
                lvi.SubItems.Add(item.IlacKullanimSikligi);
                lvi.SubItems.Add(item.ReceteDetayId.ToString());
                lvRecete.Items.Add(lvi);
            }
        }

        private void btnIlacSil_Click(object sender, EventArgs e)
        {
            if (lvRecete.SelectedIndices.Count > 0)
                _receteDetayRepository.Delete(Convert.ToInt32(lvRecete.SelectedItems[0].SubItems[2].Text));

            ReceteListesiDoldur();
        }

        private void btnYapilanHizmetEkle_Click(object sender, EventArgs e)
        {
            if (_secilenHasta == null) return;
            var hizmet = _hizmetService.GetHizmetByName(cbHizmetler.selectedValue);
            try
            {
                var hizmetHareketler = new HastaHizmetHareketler
                {
                    Tarih = DateTime.Now,
                    KabulID = _secilenHasta.KabulID,
                    HizmetID = hizmet.HizmetID,
                    Tutar = hizmet.Ucret
                };
                var result = _hastaHizmetHareketService.Create(hizmetHareketler);
                if (result.IsSucceed)
                {
                    MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                // ignored
            }
            HastaHizmetHareketlerDoldur();
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
                lvi.SubItems.Add(item.Tutar.ToString());
                lvHizmetHareketler.Items.Add(lvi);
            }
        }

        private void btnYapilanHizmetSil_Click(object sender, EventArgs e)
        {
            if (lvHizmetHareketler.SelectedIndices.Count > 0)
                _hastaHizmetHareketRepository.Delete(Convert.ToInt32(lvHizmetHareketler.SelectedItems[0].SubItems[0].Text));

            HastaHizmetHareketlerDoldur();
        }

        private void btnReceteYazdir_Click(object sender, EventArgs e)
        {
            var teshis = _teshisService.GetTeshisByKabulId(_secilenHasta.KabulID);
            if (_secilenHasta == null || teshis == null)
            {
                MessageBox.Show("Lütfen İlk Önce Hasta Seçimi ve Teşhis Koy İşlemlerini Gerçekleştiriniz!", "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var receteId = _receteService.GetReceteId(_secilenHasta.KabulID);
            var frm = new FormReceteYazdir(_secilenHasta, receteId, teshis);
            frm.Show();
        }

        private void btnTahlilGetir_Click(object sender, EventArgs e)
        {
            if (_secilenHasta == null)
            {
                MessageBox.Show("Lütfen İlk Önce Hasta Seçimi İşlemlerini Gerçekleştiriniz!", "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var frm = new FormTahlilYazdir(_secilenHasta,cbTahliller.selectedValue);
            frm.Show();
        }
    }
}
