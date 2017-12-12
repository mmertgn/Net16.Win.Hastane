using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.BLL.Infrastructure.Messaging.Abstracts;
using Hastane.BLL.Infrastructure.Messaging.SystemNetMail;
using Hastane.BLL.Models;
using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Ninject;

namespace Hastane.PL
{
    public partial class FormPersonelIslemleri : Form
    {
        private Personeller SecilenPersonel;
        private readonly IPersonelService _personelService;
        private readonly IPersonelRepository _personelRepo;
        private readonly IUnvanRepository _unvanRepo;
        private readonly IKlinikRepository _klinikRepo;
        private readonly IMessaging _messageService;

        Random rnd = new Random();
        string _personelKod;
        private SystemNetMailManager _mailGonder;
        private MessageResult mr;
        private object secilenKlinikID;

        public FormPersonelIslemleri()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _personelRepo = container.Get<IPersonelRepository>();
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
            int _secilenPersonelID = Convert.ToInt32(dgvPersoneller.CurrentRow.Cells[0].Value);
            if (_secilenPersonelID == 0) return;
            SecilenPersonel = _personelService.GetPersonelFindById(_secilenPersonelID);
            txtTCKimlikNo.Text = SecilenPersonel.TCKimlikNo;
            txtPersonelAd.Text = SecilenPersonel.Ad;
            txtPersonelSoyad.Text = SecilenPersonel.Soyad;
            txtPersonelEmail.Text = SecilenPersonel.Email;
            txtPersonelCepTel.Text = SecilenPersonel.CepTel;
            txtPersonelEvTel.Text = SecilenPersonel.EvTel;
            txtPersonelAdres.Text = SecilenPersonel.Adres;
            txtSicilNo.Text = SecilenPersonel.SicilNo;

            var klinik = _klinikRepo.GetList();
            var bulunanKlinikIndex = klinik.TakeWhile(item => item.KlinikAd != SecilenPersonel.Klinikler.KlinikAd).Count();
            cbKlinikler.selectedIndex = bulunanKlinikIndex;
            var unvan = _unvanRepo.GetList();
            var bulunanUnvanIndex = unvan.TakeWhile(item => item.PersonelUnvan != SecilenPersonel.Unvanlar.PersonelUnvan).Count();
            cbUnvanlar.selectedIndex = bulunanUnvanIndex;
            dtpPersonelDogumTarihi.Value = SecilenPersonel.DogumTarihi.Date;
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
                _personelKod = "DR" + rnd.Next(100, 1000);
            }
            else
            {
                _personelKod = "SKR" + rnd.Next(100, 1000);
            }
            return _personelKod;
        }
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            var klinikId = 0;
            _personelKod = PersonelKodOlusturucu();
            var unvan = _unvanRepo.UnvanGetir(cbUnvanlar.selectedValue).FirstOrDefault();
            if (cbKlinikler.selectedValue !="Diğer...")
            {
                klinikId = _klinikRepo.KlinikGetir(cbKlinikler.selectedValue).Select(x=>x.KlinikID).FirstOrDefault();
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
            if (SecilenPersonel == null) return;

            SecilenPersonel.TCKimlikNo = txtTCKimlikNo.Text;
            SecilenPersonel.Ad = txtPersonelAd.Text;
            SecilenPersonel.Soyad = txtPersonelSoyad.Text;
            SecilenPersonel.Email = txtPersonelEmail.Text;
            SecilenPersonel.CepTel = txtPersonelCepTel.Text;
            SecilenPersonel.EvTel = txtPersonelEvTel.Text;
            SecilenPersonel.DogumTarihi = dtpPersonelDogumTarihi.Value;
            var klinik = _klinikRepo.KlinikGetir(cbKlinikler.selectedValue).FirstOrDefault();
            var unvan = _unvanRepo.UnvanGetir(cbUnvanlar.selectedValue).FirstOrDefault();
            SecilenPersonel.UnvanID = unvan.UnvanID;
            SecilenPersonel.KlinikID = klinik.KlinikID;
            SecilenPersonel.SicilNo = txtSicilNo.Text;
            SecilenPersonel.Adres = txtPersonelAdres.Text;

            var result = _personelService.Edit(SecilenPersonel);
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
            if (SecilenPersonel != null)
            {
                var result = _personelService.Delete(SecilenPersonel.PersonelID);
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
