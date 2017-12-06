using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Ninject;
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
    public partial class FormSistemYonetim : Form
    {
        private readonly IKlinikRepository _klinikRepository;
        private readonly IKlinikService _klinikService;

        private int _secilenKlinikId;
        private Klinikler SecilenKlinik;
        public FormSistemYonetim()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _klinikRepository = container.Get<IKlinikRepository>();
            _klinikService = container.Get<IKlinikService>();

            InitializeComponent();
        }

        private void FormSistemYonetim_Load(object sender, EventArgs e)
        {
            KlinikDoldur();
        }
        private void KlinikTemizle()
        {
            txtKlinikAd.Text = "";
            txtKlinikAciklama.Text = "";
        }
        private void KlinikDoldur()
        {
            dgvKlinikler.Rows.Clear();
            var sayac = 0;
            var model = _klinikRepository.GetList().Select(x => new
            {
                KlinikID = x.KlinikID,
                KlinikAd = x.KlinikAd,
                KlinikAciklama = x.Aciklama
            });
            foreach (var item in model)
            {
                dgvKlinikler.Rows.Add();
                dgvKlinikler.Rows[sayac].Cells[0].Value = item.KlinikID;
                dgvKlinikler.Rows[sayac].Cells[1].Value = item.KlinikAd;
                dgvKlinikler.Rows[sayac].Cells[2].Value = item.KlinikAciklama;
                sayac++;
            }

        }

        private void txtKlinikAdAra_OnValueChanged(object sender, EventArgs e)
        {
            dgvKlinikler.Rows.Clear();
            var sayac = 0;
            var model2 = _klinikService.KlinikListWithSorgu(x => (x.KlinikAd).Contains(txtKlinikAdAra.Text))
                .Select(x => new
                {
                    KlinikID = x.KlinikID,
                    KlinikAd = x.KlinikAd,
                    KlinikAciklama = x.Aciklama
                });
            foreach (var item in model2)
            {
                dgvKlinikler.Rows.Add();
                dgvKlinikler.Rows[sayac].Cells[0].Value = item.KlinikID;
                dgvKlinikler.Rows[sayac].Cells[1].Value = item.KlinikAd;
                dgvKlinikler.Rows[sayac].Cells[2].Value = item.KlinikAciklama;
                sayac++;
            }
        }

        private void btnKlinikEkle_Click(object sender, EventArgs e)
        {

            Klinikler model = new Klinikler
            {
                KlinikAd = txtKlinikAd.Text,
                Aciklama = txtKlinikAciklama.Text,
               
            };

            var result = _klinikService.Create(model);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            KlinikDoldur();
            KlinikTemizle();
        }

        private void btnKlinikGuncelle_Click(object sender, EventArgs e)
        {
            if (SecilenKlinik != null)
            {
                SecilenKlinik.KlinikID = _secilenKlinikId;
                SecilenKlinik.KlinikAd = txtKlinikAd.Text;
                SecilenKlinik.Aciklama = txtKlinikAciklama.Text;
             

                var result = _klinikService.Edit(SecilenKlinik);
                if (result.IsSucceed)
                {
                    MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                KlinikDoldur();
                KlinikTemizle();
            }
        }

        private void btnKlinikSil_Click(object sender, EventArgs e)
        {
            if (SecilenKlinik != null)
            {
                var result = _klinikService.Delete(SecilenKlinik.KlinikID);
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
                KlinikDoldur();
                KlinikTemizle();
            }
        }

        private void dgvKlinikler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _secilenKlinikId = Convert.ToInt32(dgvKlinikler.SelectedRows[0].Cells[0].Value);
            if (_secilenKlinikId == 0) return;
            SecilenKlinik = _klinikService.GetKlinikById(_secilenKlinikId);
            txtKlinikAd.Text = SecilenKlinik.KlinikAd;
            txtKlinikAciklama.Text = SecilenKlinik.Aciklama;
        }

      
    }
}
