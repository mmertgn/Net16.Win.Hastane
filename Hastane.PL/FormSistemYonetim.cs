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
        private readonly IKurumRepository _kurumRepository;
        private readonly IKurumService _kurumService;
        private readonly IUnvanRepository _unvanRepository;
        private readonly IUnvanService _unvanService;
        private readonly IHizmetRepository _hizmetRepository;
        private readonly IHizmetService _hizmetService;

        private int _secilenKlinikId;
        private Klinikler SecilenKlinik;
        private int _secilenKurumId;
        private Kurumlar SecilenKurum;
        private int _secilenUnvanId;
        private Unvanlar SecilenUnvan;
        private int _secilenHizmetId;
        private Hizmetler SecilenHizmet;
        public FormSistemYonetim()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _klinikRepository = container.Get<IKlinikRepository>();
            _klinikService = container.Get<IKlinikService>();
            _kurumRepository = container.Get<IKurumRepository>();
            _kurumService = container.Get<IKurumService>();
            _unvanRepository = container.Get<IUnvanRepository>();
            _unvanService = container.Get<IUnvanService>();
            _hizmetRepository = container.Get<IHizmetRepository>();
            _hizmetService = container.Get<IHizmetService>();

            InitializeComponent();
        }

        private void FormSistemYonetim_Load(object sender, EventArgs e)
        {
            KlinikDoldur();
            KurumDoldur();
            UnvanDoldur();
            CbKlinikDoldur();
            HizmetDoldur();
        }

        private void HizmetDoldur()
        {
            dgvHizmetler.Rows.Clear();
            var sayac = 0;
            var model = _hizmetRepository.GetList().Select(x => new
            {
                 HizmetID= x.HizmetID,
                HizmetAdi = x.HizmetAdi,
                KlinikAd=x.Klinikler.KlinikAd,
                Ucret=x.Ucret,
                Aciklama=x.Aciklama

            });
            foreach (var item in model)
            {
                dgvHizmetler.Rows.Add();
                dgvHizmetler.Rows[sayac].Cells[0].Value = item.HizmetID;
                dgvHizmetler.Rows[sayac].Cells[1].Value = item.HizmetAdi;
                dgvHizmetler.Rows[sayac].Cells[2].Value = item.KlinikAd;
                dgvHizmetler.Rows[sayac].Cells[3].Value = item.Ucret;
                dgvHizmetler.Rows[sayac].Cells[4].Value = item.Aciklama;
                sayac++;
            }
        }

        private void HizmetTemizle()
        {
            txtHizmetAdi.Text = "";
            txtHizmetUcreti.Text = "";
            txtHizmetAciklama.Text = "";
            
        }

        private void UnvanDoldur()
        {
            dgvUnvanlar.Rows.Clear();
            var sayac = 0;
            var model = _unvanRepository.GetList().Select(x => new
            {
                UnvanID = x.UnvanID,
                UnvanAdi = x.PersonelUnvan,
                
            });
            foreach (var item in model)
            {
                dgvUnvanlar.Rows.Add();
                dgvUnvanlar.Rows[sayac].Cells[0].Value = item.UnvanID;
                dgvUnvanlar.Rows[sayac].Cells[1].Value = item.UnvanAdi;
                sayac++;
            }
        }

        private void UnvanTemizle()
        {
            txtUnvanAdi.Text = "";
        }

        private void KurumDoldur()
        {
            dgvKurumlar.Rows.Clear();
            var sayac = 0;
            var model = _kurumRepository.GetList().Select(x => new
            {
                KurumID = x.KurumID,
                KurumAdi = x.KurumAd,
                Kurumİskonto = x.Iskonto
            });
            foreach (var item in model)
            {
                dgvKurumlar.Rows.Add();
                dgvKurumlar.Rows[sayac].Cells[0].Value = item.KurumID;
                dgvKurumlar.Rows[sayac].Cells[1].Value = item.KurumAdi;
                dgvKurumlar.Rows[sayac].Cells[2].Value = item.Kurumİskonto;
                sayac++;
            }
        }
        private void KurumTemizle()
        {
            txtKurumAdi.Text = "";
            txtKurumIskonto.Text = "";
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

        private void CbKlinikDoldur()
        {
            var model = _klinikRepository.GetList();
            model.ForEach(item =>
            {
                cbKlinik.AddItem(item.KlinikAd);
            }
            );
            cbKlinik.selectedIndex = 0;
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

        private void dgvKurumlar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _secilenKurumId = Convert.ToInt32(dgvKurumlar.SelectedRows[0].Cells[0].Value);
            if (_secilenKurumId == 0) return;
            SecilenKurum = _kurumService.GetKurumById(_secilenKurumId);
            txtKurumAdi.Text = SecilenKurum.KurumAd;
            txtKurumIskonto.Text = Convert.ToString(SecilenKurum.Iskonto);
        }

        private void txtKurumAdAra_OnValueChanged(object sender, EventArgs e)
        {
            dgvKurumlar.Rows.Clear();
            var sayac = 0;
            var model2 = _kurumService.KurumListWithSorgu(x => (x.KurumAd).Contains(txtKurumAdAra.Text))
                .Select(x => new
                {
                    KurumID = x.KurumID,
                    KurumAdi = x.KurumAd,
                    Kurumİskonto = x.Iskonto
                });
            foreach (var item in model2)
            {
                dgvKurumlar.Rows.Add();
                dgvKurumlar.Rows[sayac].Cells[0].Value = item.KurumID;
                dgvKurumlar.Rows[sayac].Cells[1].Value = item.KurumAdi;
                dgvKurumlar.Rows[sayac].Cells[2].Value = item.Kurumİskonto;
                sayac++;
            }
        }

        private void btnKurumEkle_Click(object sender, EventArgs e)
        {
            Kurumlar model = new Kurumlar
            {
                KurumAd = txtKurumAdi.Text,
                Iskonto = Convert.ToInt32(txtKurumIskonto.Text),

            };

            var result = _kurumService.Create(model);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            KurumDoldur();
            KurumTemizle();
        }

        private void btnKurumGuncelle_Click(object sender, EventArgs e)
        {
            if (SecilenKurum != null)
            {
                SecilenKurum.KurumID = _secilenKurumId;
                SecilenKurum.KurumAd = txtKurumAdi.Text;
                SecilenKurum.Iskonto = Convert.ToInt32(txtKurumIskonto.Text);


                var result = _kurumService.Edit(SecilenKurum);
                if (result.IsSucceed)
                {
                    MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                KurumDoldur();
                KurumTemizle();
            }
        }

        private void btnKurumSil_Click(object sender, EventArgs e)
        {
            if (SecilenKurum != null)
            {
                var result = _kurumService.Delete(SecilenKurum.KurumID);
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
                KurumDoldur();
                KurumTemizle();
            }
        }

        private void txtUnvanAdAra_OnValueChanged(object sender, EventArgs e)
        {
            dgvUnvanlar.Rows.Clear();
            var sayac = 0;
            var model2 = _unvanService.UnvanListWithSorgu(x => (x.PersonelUnvan).Contains(txtUnvanAdAra.Text))
                .Select(x => new
                {
                    UnvanID = x.UnvanID,
                    UnvanAdi = x.PersonelUnvan,
         
                });
            foreach (var item in model2)
            {
                dgvUnvanlar.Rows.Add();
                dgvUnvanlar.Rows[sayac].Cells[0].Value = item.UnvanID;
                dgvUnvanlar.Rows[sayac].Cells[1].Value = item.UnvanAdi;
                sayac++;
            }
        }

        private void btnUnvanEkle_Click(object sender, EventArgs e)
        {
            Unvanlar model = new Unvanlar
            {
                PersonelUnvan = txtUnvanAdi.Text
            };

            var result = _unvanService.Create(model);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UnvanDoldur();
            UnvanTemizle();
        }

        private void btnUnvanGuncelle_Click(object sender, EventArgs e)
        {
            if (SecilenUnvan != null)
            {
                SecilenUnvan.UnvanID = _secilenUnvanId;
                SecilenUnvan.PersonelUnvan = txtUnvanAdi.Text;
              

                var result = _unvanService.Edit(SecilenUnvan);
                if (result.IsSucceed)
                {
                    MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UnvanDoldur();
                UnvanTemizle();
            }
        }

        private void btnUnvanSil_Click(object sender, EventArgs e)
        {
            if (SecilenUnvan != null)
            {
                var result = _unvanService.Delete(SecilenUnvan.UnvanID);
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
                UnvanDoldur();
                UnvanTemizle();
            }
        }

        private void dgvUnvanlar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _secilenUnvanId = Convert.ToInt32(dgvUnvanlar.SelectedRows[0].Cells[0].Value);
            if (_secilenUnvanId == 0) return;
            SecilenUnvan = _unvanService.GetUnvanById(_secilenUnvanId);
            txtUnvanAdi.Text = SecilenUnvan.PersonelUnvan;
         
        }

        private void txtHizmetAdiAra_OnValueChanged(object sender, EventArgs e)
        {
            dgvHizmetler.Rows.Clear();
            var sayac = 0;
            var model2 = _hizmetService.HizmetListWithSorgu(x => (x.HizmetAdi).Contains(txtHizmetAdiAra.Text))
                .Select(x => new
                {

                    HizmetID = x.HizmetID,
                    HizmetAdi = x.HizmetAdi,
                    KlinikAd = x.Klinikler.KlinikAd,
                    Ucret = x.Ucret,
                    Aciklama = x.Aciklama
                });
            foreach (var item in model2)
            {
                dgvHizmetler.Rows.Add();
                dgvHizmetler.Rows[sayac].Cells[0].Value = item.HizmetID;
                dgvHizmetler.Rows[sayac].Cells[1].Value = item.HizmetAdi;
                dgvHizmetler.Rows[sayac].Cells[2].Value = item.KlinikAd;
                dgvHizmetler.Rows[sayac].Cells[3].Value = item.Ucret;
                dgvHizmetler.Rows[sayac].Cells[4].Value = item.Aciklama;
                sayac++;
            }
        }

        private void dgvHizmetler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _secilenHizmetId = Convert.ToInt32(dgvHizmetler.SelectedRows[0].Cells[0].Value);
            if (_secilenHizmetId == 0) return;
            SecilenHizmet = _hizmetService.GetHizmetById(_secilenHizmetId);
            txtHizmetAdi.Text = SecilenHizmet.HizmetAdi;
            txtHizmetUcreti.Text =Convert.ToString(SecilenHizmet.Ucret);
            txtHizmetAciklama.Text = SecilenHizmet.Aciklama;

        }

        private void btnHizmetEkle_Click(object sender, EventArgs e)
        {
            Hizmetler model = new Hizmetler
            {
                HizmetAdi = txtHizmetAdi.Text,
                Ucret=Convert.ToInt32(txtHizmetUcreti.Text),
                Aciklama=txtHizmetAciklama.Text,
                KlinikID=cbKlinik.selectedIndex
            };

            var result = _hizmetService.Create(model);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HizmetDoldur();
            HizmetTemizle();
        }

        private void btnHizmetGuncelle_Click(object sender, EventArgs e)
        {
            if (SecilenHizmet != null)
            {
                SecilenHizmet.HizmetID = _secilenHizmetId;
                SecilenHizmet.HizmetAdi = txtHizmetAdi.Text;
                SecilenHizmet.Ucret = Convert.ToDecimal(txtHizmetUcreti.Text);
                SecilenHizmet.KlinikID = cbKlinik.selectedIndex;
                SecilenHizmet.Aciklama = txtHizmetAciklama.Text;


                var result = _hizmetService.Edit(SecilenHizmet);
                if (result.IsSucceed)
                {
                    MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                HizmetDoldur();
                HizmetTemizle();
            }
        }

        private void btnHizmetSil_Click(object sender, EventArgs e)
        {
            if (SecilenHizmet != null)
            {
                var result = _hizmetService.Delete(SecilenHizmet.HizmetID);
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
                HizmetDoldur();
                HizmetTemizle();
            }
        }

        private void dgvKlinikler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
