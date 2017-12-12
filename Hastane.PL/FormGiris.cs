using Hastane.BLL.Models;
using System;
using System.Windows.Forms;

namespace Hastane.PL
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            btnGiris.Focus();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            var sonuc = personel.UyeGirisi(txtKullaniciAdi.Text,txtSifre.Text);
            if (sonuc)
            {
                var frm = new FormAnaSayfa();
                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı yada Şifre Girdiniz. Lütfen Tekrar Deneyiniz!", "Giriş Yapılamadı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtKullaniciAdi.Focus();
            }
        }
    }
}
