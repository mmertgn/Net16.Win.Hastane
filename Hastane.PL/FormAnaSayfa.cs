using Hastane.BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.PL
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }
        
        bool frmLoadFirst = true;
        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            btnKullaniciBilgi.LabelText = Genel.KullaniciAdi + " " + Genel.KullaniciSoyadi;
            FormAnaSayfaIcerik frm = new FormAnaSayfaIcerik();
            FormAcikmi(frm);
        }

        private void FormAcikmi(Form AcilacakForm)
        {
            if (frmLoadFirst)
            {
                if (pnlIcerik != null)
                {
                    while (pnlIcerik.Controls.Count > 0)
                    {
                        pnlIcerik.Controls[0].Dispose();
                    }
                }
                AcilacakForm.TopLevel = false;
                AcilacakForm.AutoScroll = true;
                if (pnlIcerik != null)
                {
                    pnlIcerik.Controls.Add(AcilacakForm);
                    AcilacakForm.Dock = DockStyle.Fill;
                    AcilacakForm.Show();
                    frmLoadFirst = false;
                }
            }
            else
            {
                if (pnlIcerik.Controls[0].Name != AcilacakForm.Name)
                {
                    if (pnlIcerik != null)
                    {
                        while (pnlIcerik.Controls.Count > 0)
                        {
                            pnlIcerik.Controls[0].Dispose();
                        }
                    }
                    AcilacakForm.TopLevel = false;
                    AcilacakForm.AutoScroll = true;
                    this.pnlIcerik.Controls.Add(AcilacakForm);
                    AcilacakForm.Dock = DockStyle.Fill;
                    AcilacakForm.Show();
                }
            }

        }
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnAnaSayfa.Location.Y);
            FormAnaSayfaIcerik frm = new FormAnaSayfaIcerik();
            FormAcikmi(frm);
        }

        private void btnHastaKabul_Click(object sender, EventArgs e)
        {
            this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnHastaKabul.Location.Y);
            FormHastaKabul frm = new FormHastaKabul();
            FormAcikmi(frm);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnRandevu.Location.Y);

            FormRandevu frm = new FormRandevu();
            FormAcikmi(frm);
        }

        private void btnSistemYonetimi_Click(object sender, EventArgs e)
        {
            this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnSistemYonetimi.Location.Y);
            FormSistemYonetim frm = new FormSistemYonetim();
            FormAcikmi(frm);
        }


        private void btnDoktorIslemleri_Click(object sender, EventArgs e)
        {
            this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnDoktorIslemleri.Location.Y);
            FormDoktorIslemleri frm = new FormDoktorIslemleri();
            FormAcikmi(frm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lblTarih.Text = "Tarih : " + datetime.ToShortDateString() + " \nSaat : "+ datetime.ToShortTimeString();
        }

        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnPersonelIslemleri.Location.Y);
            FormPersonelIslemleri frm = new FormPersonelIslemleri();
            FormAcikmi(frm);
        }

        private void btnOdemeIslemleri_Click(object sender, EventArgs e)
        {
            this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnOdemeIslemleri.Location.Y);
            FormOdemeIslemleri frm = new FormOdemeIslemleri();
            FormAcikmi(frm);
        }

        private void btnTahlilIslemleri_Click(object sender, EventArgs e)
        {
            this.pbSeciliSayfa.Location = new Point(
                176,
                this.btnTahlilIslemleri.Location.Y);
            FormTahlilIslemleri frm = new FormTahlilIslemleri();
            FormAcikmi(frm);
        }

        private void btnKullaniciBilgi_Click(object sender, EventArgs e)
        {
            this.pbSeciliSayfa.Location = new Point(
                this.pnlKullaniciBilgileri.Location.X,
                this.pnlKullaniciBilgileri.Location.Y);
            FormKullaniciBilgileri frm = new FormKullaniciBilgileri();
            FormAcikmi(frm);
        }
    }
}
