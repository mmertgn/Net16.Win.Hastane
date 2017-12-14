using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Ninject;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hastane.PL
{
    public partial class FormPersonelIslemleri : Form
    {
        private Personeller _secilenPersonel;
        private readonly IPersonelService _personelService;
        private readonly IUnvanRepository _unvanRepo;
        private readonly IKlinikRepository _klinikRepo;

        private readonly Random _rnd = new Random();
        string _personelKod;

        public FormPersonelIslemleri()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _personelService = container.Get<IPersonelService>();
            _unvanRepo = container.Get<IUnvanRepository>();
            _klinikRepo = container.Get<IKlinikRepository>();
            InitializeComponent();
        }

        private void PersonelListele()
        {
            var model = _personelService.PersonelListele();
            dgvPersoneller.DataSource = model;
            PersonelAyrıntıDuzenlemesi();
        }

        private void FormPersonelIslemleri_Load(object sender, EventArgs e)
        {
            PersonelListele();
            CbUnvanDoldur();
            CbKlinikDoldur();
            Temizle();
        }

        private void Temizle()
        {
            txtPersonelAd.Text = "";
            txtPersonelAdres.Text = "";
            txtTCKimlikNo.Text = "";
            txtSicilNo.Text = "";
            txtPersonelSoyad.Text = "";
            txtPersonelEvTel.Text = "";
            txtPersonelEmail.Text = "";
            txtPersonelCepTel.Text = "";
            txtPersonelAdres.Text = "";
            cbKlinikler.selectedIndex = 0;
            cbUnvanlar.selectedIndex = 0;
            dtpPersonelDogumTarihi.Value = DateTime.Now;
        }

        private void PersonelAyrıntıDuzenlemesi()
        {
            dgvPersoneller.Columns[0].Visible = false;
            dgvPersoneller.Columns[1].Visible = false;
            dgvPersoneller.Columns[2].Visible = false;

            dgvPersoneller.Columns[13].Visible = false;
        }

        private void dgvPersoneller_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var secilenPersonelId = Convert.ToInt32(dgvPersoneller.CurrentRow.Cells[0].Value);
            if (secilenPersonelId == 0) return;
            _secilenPersonel = _personelService.GetPersonelFindById(secilenPersonelId);
            txtTCKimlikNo.Text = _secilenPersonel.TCKimlikNo;
            txtPersonelAd.Text = _secilenPersonel.Ad;
            txtPersonelSoyad.Text = _secilenPersonel.Soyad;
            txtPersonelEmail.Text = _secilenPersonel.Email;
            txtPersonelCepTel.Text = _secilenPersonel.CepTel;
            txtPersonelEvTel.Text = _secilenPersonel.EvTel;
            txtPersonelAdres.Text = _secilenPersonel.Adres;
            txtSicilNo.Text = _secilenPersonel.SicilNo;
            try
            {
                var bulunanKlinikIndex = _klinikRepo.GetList().TakeWhile(item => item.KlinikAd != _secilenPersonel.Klinikler.KlinikAd).Count();
                cbKlinikler.selectedIndex = bulunanKlinikIndex;
            }
            catch (Exception exception)
            {
                cbKlinikler.selectedIndex = _klinikRepo.GetKlinikCount();
            }
            try
            {
                var unvan = _unvanRepo.GetList();
                var bulunanUnvanIndex = unvan.TakeWhile(item => item.PersonelUnvan != _secilenPersonel.Unvanlar.PersonelUnvan).Count();
                cbUnvanlar.selectedIndex = bulunanUnvanIndex;
            }
            catch (Exception)
            {
                // ignored
            }
            dtpPersonelDogumTarihi.Value = _secilenPersonel.DogumTarihi.Date;
        }

        private void CbUnvanDoldur()
        {

            var model = _unvanRepo.GetList();
            model.ForEach(item =>
            {
                cbUnvanlar.AddItem(item.PersonelUnvan);
            });
            cbUnvanlar.selectedIndex = 0;
        }

        private void CbKlinikDoldur()
        {
            var model = _klinikRepo.GetList();
            model.ForEach(item =>
            {
                cbKlinikler.AddItem(item.KlinikAd);
            });
            cbKlinikler.AddItem("Diğer...");
            cbKlinikler.selectedIndex = 0;

        }

        private void txtPersonelAdSoyadAra_OnValueChanged(object sender, EventArgs e)
        {
            var model =
                _personelService.PersonelleriOzelListele(txtPersonelAdSoyadAra.Text, txtPersonelKoduAra.Text);
            dgvPersoneller.DataSource = model;
            PersonelAyrıntıDuzenlemesi();
        }

        private string PersonelKodOlusturucu()
        {
            if (cbUnvanlar.selectedValue.Contains("Doktor"))
            {
                _personelKod = "DR" + _rnd.Next(100, 1000);
            }
            else if (cbUnvanlar.selectedValue.Contains("Laborant"))
            {
                _personelKod = "LAB" + _rnd.Next(100, 1000);
            }
            else
            {
                _personelKod = "SKR" + _rnd.Next(100, 1000);
            }
            return _personelKod;
        }
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            int? klinikId;
            _personelKod = PersonelKodOlusturucu();
            var unvan = _unvanRepo.UnvanGetir(cbUnvanlar.selectedValue).FirstOrDefault();
            if (cbKlinikler.selectedValue != "Diğer...")
            {
                klinikId = _klinikRepo.KlinikGetir(cbKlinikler.selectedValue).Select(x => x.KlinikID).FirstOrDefault();
            }
            else
            {
                klinikId = null;
            }
            var model = new Personeller
            {
                PersonelKodu = _personelKod,
                TCKimlikNo = txtTCKimlikNo.Text,
                Ad = txtPersonelAd.Text,
                Soyad = txtPersonelSoyad.Text,
                Email = txtPersonelEmail.Text,
                CepTel = txtPersonelCepTel.Text,
                EvTel = txtPersonelEvTel.Text,
                DogumTarihi = dtpPersonelDogumTarihi.Value.Date,
                SicilNo = txtSicilNo.Text,
                Adres = txtPersonelAdres.Text,
                KullaniciAdi = txtPersonelEmail.Text,
                Sifre = _personelKod,
                UnvanID = unvan.UnvanID,
                KlinikID = klinikId
            };

            var result = _personelService.Create(model);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, @"İşlem Gerçekleştirildi!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), @"İşlem Gerçekleştirilemedi!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PersonelListele();
            Temizle();
        }



        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenPersonel == null) return;

            _secilenPersonel.TCKimlikNo = txtTCKimlikNo.Text;
            _secilenPersonel.Ad = txtPersonelAd.Text;
            _secilenPersonel.Soyad = txtPersonelSoyad.Text;
            _secilenPersonel.Email = txtPersonelEmail.Text;
            _secilenPersonel.CepTel = txtPersonelCepTel.Text;
            _secilenPersonel.EvTel = txtPersonelEvTel.Text;
            _secilenPersonel.DogumTarihi = dtpPersonelDogumTarihi.Value;
            var klinik = _klinikRepo.KlinikGetir(cbKlinikler.selectedValue).FirstOrDefault();
            var unvan = _unvanRepo.UnvanGetir(cbUnvanlar.selectedValue).FirstOrDefault();
            _secilenPersonel.UnvanID = unvan.UnvanID;
            _secilenPersonel.KlinikID = klinik.KlinikID;
            _secilenPersonel.SicilNo = txtSicilNo.Text;
            _secilenPersonel.Adres = txtPersonelAdres.Text;

            var result = _personelService.Edit(_secilenPersonel);
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
            PersonelListele();
            Temizle();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (_secilenPersonel != null)
            {
                var result = _personelService.Delete(_secilenPersonel.PersonelID);
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
                PersonelListele();
                Temizle();
            }
        }
    }
}
