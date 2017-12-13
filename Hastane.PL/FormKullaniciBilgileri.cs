using Hastane.BLL.Models;
using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Ninject;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Hastane.PL
{
    public partial class FormKullaniciBilgileri : Form
    {
        private readonly IPersonelService _personelService;
        private readonly IPersonelRepository _personelRepo;
        private readonly IUnvanRepository _unvanRepo;
        private readonly IKlinikRepository _klinikRepo;

        public FormKullaniciBilgileri()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _personelRepo = container.Get<IPersonelRepository>();
            _personelService = container.Get<IPersonelService>();
            _unvanRepo = container.Get<IUnvanRepository>();
            _klinikRepo = container.Get<IKlinikRepository>();

            InitializeComponent();
        }

        private void FormKullaniciBilgileri_Load(object sender, EventArgs e)
        {
            CbUnvanDoldur();
            CbKlinikDoldur();
            KullaniciBilgileriDoldur();

        }

        private void KullaniciBilgileriDoldur()
        {
            var secilenPersonel = _personelRepo.FindById(Genel.LoginKullaniciID);

         
                txtTCKimlikNo.Text = secilenPersonel.TCKimlikNo;
                txtPersonelAd.Text = secilenPersonel.Ad;
                txtSoyad.Text = secilenPersonel.Soyad;
                txtEmail.Text = secilenPersonel.Email;
                txtCepTelefonu.Text = secilenPersonel.CepTel;
                txtEvTelefonu.Text = secilenPersonel.EvTel;
                txtAdres.Text = secilenPersonel.Adres;
                txtSicilNo.Text = secilenPersonel.SicilNo;
                txtKullaniciAdi.Text = secilenPersonel.KullaniciAdi;
                txtSifre.Text = secilenPersonel.Sifre;

                var klinik = _klinikRepo.GetList();
                var bulunanKlinikIndex = klinik.TakeWhile(item => item.KlinikAd != secilenPersonel.Klinikler.KlinikAd).Count();
                cbKlinikler.selectedIndex = bulunanKlinikIndex;
                var unvan = _unvanRepo.GetList();
                var bulunanUnvanIndex = unvan.TakeWhile(item => item.PersonelUnvan != secilenPersonel.Unvanlar.PersonelUnvan).Count();
                cbUnvanlar.selectedIndex = bulunanUnvanIndex;
                dtpDogumTarihi.Value = secilenPersonel.DogumTarihi.Date;
            
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
        private void Temizle()
        {
            txtPersonelAd.Text = "";
            txtAdres.Text = "";
            txtTCKimlikNo.Text = "";
            txtSicilNo.Text = "";
            txtSoyad.Text = "";
            txtEvTelefonu.Text = "";
            txtEmail.Text = "";
            txtCepTelefonu.Text = "";
            cbKlinikler.selectedIndex = 0;
            cbUnvanlar.selectedIndex = 0;
            dtpDogumTarihi.Value = DateTime.Now;
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var secilenPersonel = _personelRepo.FindById(Genel.LoginKullaniciID);
            if (secilenPersonel == null) return;

            secilenPersonel.TCKimlikNo = txtTCKimlikNo.Text;
            secilenPersonel.Ad = txtPersonelAd.Text;
            secilenPersonel.Soyad = txtSoyad.Text;
            secilenPersonel.Email = txtEmail.Text;
            secilenPersonel.CepTel = txtCepTelefonu.Text;
            secilenPersonel.EvTel = txtEvTelefonu.Text;
            secilenPersonel.DogumTarihi = dtpDogumTarihi.Value;
            var klinik = _klinikRepo.KlinikGetir(cbKlinikler.selectedValue).FirstOrDefault();
            var unvan = _unvanRepo.UnvanGetir(cbUnvanlar.selectedValue).FirstOrDefault();
            secilenPersonel.UnvanID = unvan.UnvanID;
            secilenPersonel.KlinikID = klinik.KlinikID;
            secilenPersonel.SicilNo = txtSicilNo.Text;
            secilenPersonel.Adres = txtAdres.Text;

            var result = _personelService.Edit(secilenPersonel);
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
            
            Temizle();
        }
    }
}
