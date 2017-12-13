using Hastane.BLL.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hastane.PL
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private bool _frmLoadFirst = true;
        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            btnKullaniciBilgi.LabelText = Genel.KullaniciAdi + " " + Genel.KullaniciSoyadi;
            var frm = new FormAnaSayfaIcerik();
            FormAcikmi(frm);
        }

        private void FormAcikmi(Form acilacakForm)
        {
            if (_frmLoadFirst)
            {
                if (pnlIcerik != null)
                {
                    while (pnlIcerik.Controls.Count > 0)
                    {
                        pnlIcerik.Controls[0].Dispose();
                    }
                }
                acilacakForm.TopLevel = false;
                acilacakForm.AutoScroll = true;
                if (pnlIcerik == null) return;
                pnlIcerik.Controls.Add(acilacakForm);
                acilacakForm.Dock = DockStyle.Fill;
                acilacakForm.Show();
                _frmLoadFirst = false;
            }
            else
            {
                if (pnlIcerik.Controls[0].Name == acilacakForm.Name) return;
                if (pnlIcerik != null)
                {
                    while (pnlIcerik.Controls.Count > 0)
                    {
                        pnlIcerik.Controls[0].Dispose();
                    }
                }
                acilacakForm.TopLevel = false;
                acilacakForm.AutoScroll = true;
                this.pnlIcerik.Controls.Add(acilacakForm);
                acilacakForm.Dock = DockStyle.Fill;
                acilacakForm.Show();
            }

        }
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnAnaSayfa.Location.Y);
            var frm = new FormAnaSayfaIcerik();
            FormAcikmi(frm);
        }

        private void btnHastaKabul_Click(object sender, EventArgs e)
        {
            if (Genel.PersonelUnvan.Contains("Sekreter") || Genel.PersonelUnvan.Contains("Danışman") || Genel.PersonelUnvan.Contains("Yönetici"))
            {
                this.pbSeciliSayfa.Location = new Point(
                    176,
                    this.btnHastaKabul.Location.Y);
                var frm = new FormHastaKabul();
                FormAcikmi(frm);
            }
            else
            {
                MessageBox.Show("Bu Sayfayı Görüntülemek İçin Yetkiniz Bulunmamaktadır!", "Dikkat!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            if (Genel.PersonelUnvan.Contains("Sekreter") || Genel.PersonelUnvan.Contains("Danışman") || Genel.PersonelUnvan.Contains("Yönetici"))
            {
                this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnRandevu.Location.Y);

                var frm = new FormRandevuIslemleri();
                FormAcikmi(frm);
            }
            else
            {
                MessageBox.Show("Bu Sayfayı Görüntülemek İçin Yetkiniz Bulunmamaktadır!", "Dikkat!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSistemYonetimi_Click(object sender, EventArgs e)
        {
            if (Genel.PersonelUnvan.Contains("Yönetici"))
            {
                this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnSistemYonetimi.Location.Y);
                var frm = new FormSistemYonetim();
                FormAcikmi(frm);
            }
            else
            {
                MessageBox.Show("Bu Sayfayı Görüntülemek İçin Yetkiniz Bulunmamaktadır!", "Dikkat!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnDoktorIslemleri_Click(object sender, EventArgs e)
        {
            if (Genel.PersonelUnvan.Contains("Doktor") || Genel.PersonelUnvan.Contains("Yönetici"))
            {
                this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnDoktorIslemleri.Location.Y);
                var frm = new FormDoktorIslemleri();
                FormAcikmi(frm);
            }
            else
            {
                MessageBox.Show("Bu Sayfayı Görüntülemek İçin Yetkiniz Bulunmamaktadır!", "Dikkat!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var datetime = DateTime.Now;
            this.lblTarih.Text = "Tarih : " + datetime.ToShortDateString() + " \nSaat : " + datetime.ToShortTimeString();
        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            if (!Genel.PersonelUnvan.Contains("Doktor"))
            {
                this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnPersonelIslemleri.Location.Y);
                var frm = new FormPersonelIslemleri();
                FormAcikmi(frm);
            }
            else
            {
                MessageBox.Show("Bu Sayfayı Görüntülemek İçin Yetkiniz Bulunmamaktadır!", "Dikkat!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOdemeIslemleri_Click(object sender, EventArgs e)
        {
            if (Genel.PersonelUnvan.Contains("Sekreter") || Genel.PersonelUnvan.Contains("Danışman") || Genel.PersonelUnvan.Contains("Yönetici"))
            {
                this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnOdemeIslemleri.Location.Y);
                var frm = new FormOdemeIslemleri();
                FormAcikmi(frm);
            }
            else
            {
                MessageBox.Show("Bu Sayfayı Görüntülemek İçin Yetkiniz Bulunmamaktadır!", "Dikkat!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTahlilIslemleri_Click(object sender, EventArgs e)
        {
            if (Genel.PersonelUnvan.Contains("Doktor") || Genel.PersonelUnvan.Contains("Laborant") || Genel.PersonelUnvan.Contains("Yönetici"))
            {
                this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnTahlilIslemleri.Location.Y);
                var frm = new FormTahlilIslemleri();
                FormAcikmi(frm);
            }
            else
            {
                MessageBox.Show("Bu Sayfayı Görüntülemek İçin Yetkiniz Bulunmamaktadır!", "Dikkat!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKullaniciBilgi_Click(object sender, EventArgs e)
        {
            if (!Genel.YoneticiMi)
            {
                this.pbSeciliSayfa.Location = new Point(
                           this.pnlKullaniciBilgileri.Location.X,
                           this.pnlKullaniciBilgileri.Location.Y);
                var frm = new FormKullaniciBilgileri();
                FormAcikmi(frm);
            }
            else
            {
                MessageBox.Show("Kullanici Bilgilerini Düzenlemek İçin Personel Hesabı İle Giriş Yapmalısınız!", "Dikkat!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
