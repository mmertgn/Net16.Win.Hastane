using Hastane.BLL.Infrastructure.Messaging.Abstracts;
using Hastane.BLL.Infrastructure.Messaging.SystemNetMail;
using Hastane.BLL.Models;
using Hastane.BLL.Services.Abstracts;
using Hastane.BLL.Validations;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hastane.PL
{
    public partial class FormPersonelIslemleri : Form
    {
        private Personeller SecilenPersonel;
        private int _secilenPersonelID;
        private readonly IPersonelService _personelService;
        private readonly IPersonelRepository _personelRepo;
        private readonly IUnvanRepository _unvanRepo;
        private readonly IKlinikRepository _klinikRepo;
        private readonly IMessaging _messageService;

        Random rnd = new Random();
        string drPersonelKod;
        private SystemNetMailManager _mailGonder;
        private MessageResult mr;
        string skPersonelKod;
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

            _secilenPersonelID = Convert.ToInt32(dgvPersoneller.CurrentRow.Cells[0].Value);
            if (_secilenPersonelID == 0) return;
            SecilenPersonel = _personelService.GetPersonelFindById(_secilenPersonelID);
            txtTCKimlikNo.Text = SecilenPersonel.TCKimlikNo;
            txtPersonelAd.Text = SecilenPersonel.Ad;
            txtPersonelSoyad.Text = SecilenPersonel.Soyad;
            txtPersonelEmail.Text = SecilenPersonel.Email;
            txtPersonelCepTel.Text = SecilenPersonel.CepTel;
            txtPersonelEvTel.Text = SecilenPersonel.EvTel;
            txtPersonelAdres.Text = SecilenPersonel.Adres;
            txtSicilNo.Text = Convert.ToString(SecilenPersonel.SicilNo);
            cbKlinikler.Text = SecilenPersonel.Klinikler.KlinikAd;
            cbUnvanlar.Text = SecilenPersonel.Unvanlar.PersonelUnvan;
            dtpPersonelDogumTarihi.Value = (DateTime)SecilenPersonel.DogumTarihi;

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
            cbKlinikler.selectedIndex = 0;
        }

        private void txtPersonelAdSoyadAra_OnValueChanged(object sender, EventArgs e)
        {
            var model =
             _personelService.PersonelleriOzelListele(txtPersonelAdSoyadAra.Text, txtPersonelKoduAra.Text);
            dgvPersoneller.DataSource = model;
            PersonelAyrıntıDuzenlemesi();
        }

        private void txtPersonelKoduAra_OnValueChanged(object sender, EventArgs e)
        {
            var model =
            _personelService.PersonelleriOzelListele(txtPersonelAdSoyadAra.Text, txtPersonelKoduAra.Text);
            dgvPersoneller.DataSource = model;
            PersonelAyrıntıDuzenlemesi();
        }
        //private void cbKlinikIDBul()
        //{
        //    string a = cbKlinikler.selectedValue;
        //    var klinik = _klinikRepo.GetList();
        //    klinik.ForEach(x =>
        //    {
        //        if (a ==x.KlinikAd)
        //        {
        //            =x.GetType.se
        //        }
        //    });
        //}
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
           
            var personel = _personelRepo.PersonelGetir(Convert.ToInt32(dgvPersoneller.CurrentRow.Cells[0].Value)).FirstOrDefault();

  
            var unvan = _unvanRepo.FindById(SecilenPersonel.UnvanID);
            
          
        
            if (personel != null)
            {
                if (cbUnvanlar.selectedValue.Contains("Doktor") || cbUnvanlar.selectedValue.Contains("Prof. Doktor") || cbUnvanlar.selectedValue.Contains("Dç. Doktor"))
                {
                    drPersonelKod = "DR" + rnd.Next(100, 1000);
                    Personeller personelKod = new Personeller();
                    if (personel.PersonelKodu != drPersonelKod)
                    {
                        var model = new Personeller
                        {
                            PersonelKodu = drPersonelKod,
                            TCKimlikNo = txtTCKimlikNo.Text,
                            Ad = txtPersonelAd.Text,
                            Soyad = txtPersonelSoyad.Text,
                            Email = txtPersonelEmail.Text,
                            CepTel = txtPersonelCepTel.Text,
                            EvTel = txtPersonelEvTel.Text,
                            DogumTarihi = dtpPersonelDogumTarihi.Value,
                          //  UnvanID =,
                       // KlinikID = ,
                        SicilNo = Convert.ToInt32(txtSicilNo.Text),
                            Adres = txtPersonelAdres.Text,
                            KullaniciAdi = txtPersonelEmail.Text,
                            Sifre = drPersonelKod

                        };
                        var result = _personelService.Create(model);

                        if (result.IsSucceed)
                        {
                            MessageBox.Show(result.SuccessMessage, @"İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MailGonder(kullaniciadi,sifre,mail)
                        }
                        else
                        {
                            MessageBox.Show(string.Join("\n", result.ErrorMessage), @"İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else if (cbUnvanlar.selectedValue.Contains("Sekreter"))
                    {
                        skPersonelKod = "DR" + rnd.Next(100, 1000);
                        Personeller skPersonel = new Personeller();
                        if (personel.PersonelKodu != skPersonelKod)
                        {
                            var model = new Personeller
                            {
                                PersonelKodu = drPersonelKod,
                                TCKimlikNo = txtTCKimlikNo.Text,
                                Ad = txtPersonelAd.Text,
                                Soyad = txtPersonelSoyad.Text,
                                Email = txtPersonelEmail.Text,
                                CepTel = txtPersonelCepTel.Text,
                                EvTel = txtPersonelEvTel.Text,
                                DogumTarihi = dtpPersonelDogumTarihi.Value,
                              //  UnvanID = unvan.UnvanID,//Convert.ToInt32(cbUnvanlar.selectedValue),
                               // KlinikID = klinik.KlinikID, //Convert.ToInt32(cbKlinikler.selectedValue),
                                SicilNo = Convert.ToInt32(txtSicilNo.Text),
                                Adres = txtPersonelAdres.Text,
                                KullaniciAdi = txtPersonelEmail.Text,
                                Sifre = drPersonelKod

                            };
                            var result = _personelService.Create(model);

                            if (result.IsSucceed)
                            {
                                MessageBox.Show(result.SuccessMessage, @"İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              //  MailGonder(kullaniciadi, sifre, mail);
                            }
                            else
                            {
                                MessageBox.Show(string.Join("\n", result.ErrorMessage), @"İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }


                          
                        }
                    }
                PersonelListele();
                Temizle();

            }
        }

        private void MailGonder(string kullaniciadi, string sifre, string mail)
        {
            sifre = rnd.Next(1000, 10000).ToString();
            _secilenPersonelID = Convert.ToInt32(dgvPersoneller.CurrentRow.Cells[0].Value);
            if (_secilenPersonelID == 0) return;
            SecilenPersonel = _personelService.GetPersonelFindById(_secilenPersonelID);
            var validator = new PersonelAddValidator().Validate(_secilenPersonelID);

            if (validator.IsValid)
            {
                _personelRepo.Add(model);

                if (_messageService != null)
                {
                    MessageTemplate m = new MessageTemplate();
                    m.From = mail;
                    m.To.Add(kullaniciadi);
                    m.MessageBody = sifre;
                    m.MessageSubject = "Tek kullanımlık şifre";

                    _messageService.SendMessage(m);
                }

               
        }
    

    

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            var personel = _personelRepo.PersonelGetir(Convert.ToInt32(dgvPersoneller.CurrentRow.Cells[0].Value)).FirstOrDefault(); //Seçilen Personel idsini getirir.
            if (SecilenPersonel != null)
            {
                SecilenPersonel.TCKimlikNo = txtTCKimlikNo.Text;
                SecilenPersonel.Ad = txtPersonelAd.Text;
                SecilenPersonel.Soyad = txtPersonelSoyad.Text;
                SecilenPersonel.Email = txtPersonelEmail.Text;
                SecilenPersonel.CepTel = txtPersonelCepTel.Text;
                SecilenPersonel.EvTel = txtPersonelEvTel.Text;
                SecilenPersonel.DogumTarihi = dtpPersonelDogumTarihi.Value;
                SecilenPersonel.Unvanlar.PersonelUnvan = cbUnvanlar.selectedValue;
                SecilenPersonel.Klinikler.KlinikAd = cbKlinikler.selectedValue;
                SecilenPersonel.SicilNo = Convert.ToInt32(txtSicilNo.Text);
                SecilenPersonel.Adres = txtPersonelAdres.Text;

                var result = _personelService.Edit(SecilenPersonel);
                if (result.IsSucceed)
                {
                    MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                PersonelListele();
                Temizle();
            }
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
