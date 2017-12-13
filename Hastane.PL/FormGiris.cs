using Hastane.BLL.Models;
using System;
using System.Windows.Forms;
using Hastane.BLL.Services.Abstracts;
using Ninject;

namespace Hastane.PL
{
    public partial class FormGiris : Form
    {
        private readonly IPersonelService _personelService;
        public FormGiris()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _personelService = container.Get<IPersonelService>();
            InitializeComponent();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            btnGiris.Focus();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var sonuc = _personelService.UyeGirisi(txtKullaniciAdi.Text,txtSifre.Text);
            if (sonuc)
            {
                var frm = new FormAnaSayfa();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı yada Şifre Girdiniz. Lütfen Tekrar Deneyiniz!", "Giriş Yapılamadı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtKullaniciAdi.Focus();
            }
        }
    }
}
