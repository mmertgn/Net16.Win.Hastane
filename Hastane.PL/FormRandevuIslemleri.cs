using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Ninject;

namespace Hastane.PL
{
    public partial class FormRandevuIslemleri : Form
    {
        private readonly IHastaRepository _hastaRepository;
        private readonly IHastaService _hastaService;
        private readonly IILRepository _ilRepository;
        private readonly IIlceRepository _ilceRepository;
        private readonly IKurumRepository _kurumRepository;

        private int _secilenHastaId;
        private Hastalar SecilenHasta;
        public FormRandevuIslemleri()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _hastaRepository = container.Get<IHastaRepository>();
            _hastaService = container.Get<IHastaService>();
            _ilceRepository = container.Get<IIlceRepository>();
            _ilRepository = container.Get<IILRepository>();
            _kurumRepository = container.Get<IKurumRepository>();

            InitializeComponent();
        }

        private void FormRandevuIslemleri_Load(object sender, EventArgs e)
        {
            HastaListesiDoldur();
            IlDoldur();
            KurumDoldur();
        }

        private void KurumDoldur()
        {
            var model = _kurumRepository.GetList();
            model.ForEach(item =>
                {
                    cbKurum.AddItem(item.KurumAd);
                }
            );
            cbKurum.selectedIndex = 0;
        }

        private void HastaListesiDoldur()
        {
            dgvHastalar.Rows.Clear();
            var sayac = 0;
            var model = _hastaRepository.GetList().Select(x => new
            {
                HastaId = x.HastaID,
                AdSoyad = x.Ad + " " + x.Soyad,
                TCNo = x.TCKimlikNo,
                Telefon = x.CepTel,
                Kurum = x.Kurumlar.KurumAd
            });
            foreach (var item in model)
            {
                dgvHastalar.Rows.Add();
                dgvHastalar.Rows[sayac].Cells[0].Value = item.HastaId;
                dgvHastalar.Rows[sayac].Cells[1].Value = item.AdSoyad;
                dgvHastalar.Rows[sayac].Cells[2].Value = item.TCNo;
                dgvHastalar.Rows[sayac].Cells[3].Value = item.Telefon;
                dgvHastalar.Rows[sayac].Cells[4].Value = item.Kurum;
                sayac++;
            }
        }
        private void txtAdSoyadAra_OnValueChanged(object sender, EventArgs e)
        {
            dgvHastalar.Rows.Clear();
            var sayac = 0;
            var model2 = _hastaService.HastaListWithSorgu(x => (x.Ad + " " + x.Soyad).Contains(txtAdSoyadAra.Text) && x.CepTel.Contains(txtTelefonAra.Text) && x.TCKimlikNo.Contains(txtTCKimlikNoAra.Text))
                .Select(x => new
                {
                    HastaId = x.HastaID,
                    AdSoyad = x.Ad + " " + x.Soyad,
                    TCNo = x.TCKimlikNo,
                    Telefon = x.CepTel,
                    Kurum = x.Kurumlar.KurumAd
                });
            foreach (var item in model2)
            {
                dgvHastalar.Rows.Add();
                dgvHastalar.Rows[sayac].Cells[0].Value = item.HastaId;
                dgvHastalar.Rows[sayac].Cells[1].Value = item.AdSoyad;
                dgvHastalar.Rows[sayac].Cells[2].Value = item.TCNo;
                dgvHastalar.Rows[sayac].Cells[3].Value = item.Telefon;
                dgvHastalar.Rows[sayac].Cells[4].Value = item.Kurum;
                sayac++;
            }
        }

        #region İlveİlçeListeleme
        private void IlDoldur()
        {
            var model = _ilRepository.GetList();
            model.ForEach(item =>
                {
                    cbil.AddItem(item.sehir);
                }
            );
            cbil.selectedIndex = 0;
        }
        private void cbil_onItemSelected(object sender, EventArgs e)
        {
            cbIlce.Clear();
            var il = _ilRepository.ilGetir(cbil.selectedValue).FirstOrDefault();
            var model = _ilceRepository.GetList(x => x.sehir == il.id);
            model.ForEach(item =>
                {
                    cbIlce.AddItem(item.ilce);
                }
            );
            cbIlce.selectedIndex = 0;
        }
        #endregion

        private void btnHastaKayıt_Click(object sender, EventArgs e)
        {
            var kurum = _kurumRepository.KurumGetir(cbKurum.selectedValue).FirstOrDefault(); //Seçilen Kurumun idsini getirir.

            Hastalar model = new Hastalar
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TCKimlikNo = txtTCKimlikNo.Text,
                Cinsiyet = cbCinsiyet.selectedValue,
                CepTel = txtCepTelefonu.Text,
                EvTel = txtEvTelefonu.Text,
                KanGrubu = txtKanGrubu.Text,
                DogumTarihi = dtpDogumTarihi.Value.Date,
                il = cbil.selectedValue,
                Ilce = cbIlce.selectedValue,
                KurumID = kurum.KurumID,
                Adres = txtAdres.Text
            };

            var result = _hastaService.Create(model);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HastaListesiDoldur();
        }

        private void dgvHastalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _secilenHastaId = Convert.ToInt32(dgvHastalar.SelectedRows[0].Cells[0].Value);
            if (_secilenHastaId == 0) return;
            SecilenHasta = _hastaService.GetHastaById(_secilenHastaId);
            txtAd.Text = SecilenHasta.Ad;
            txtSoyad.Text = SecilenHasta.Soyad;
            txtTCKimlikNo.Text = SecilenHasta.TCKimlikNo;
            cbCinsiyet.Text = SecilenHasta.Cinsiyet;
            txtCepTelefonu.Text = SecilenHasta.CepTel;
            txtEvTelefonu.Text = SecilenHasta.EvTel;
            txtKanGrubu.Text = SecilenHasta.KanGrubu;
            dtpDogumTarihi.Value = (DateTime) SecilenHasta.DogumTarihi;
            cbil.Text = SecilenHasta.il;
            cbIlce.Text = SecilenHasta.Ilce;
            cbKurum.Text = SecilenHasta.Kurumlar.KurumAd;
            txtAdres.Text = SecilenHasta.Adres;
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            var kurum = _kurumRepository.KurumGetir(cbKurum.selectedValue).FirstOrDefault(); //Seçilen Kurumun idsini getirir.

            SecilenHasta.Ad = txtAd.Text;
            SecilenHasta.Soyad = txtSoyad.Text;
            SecilenHasta.TCKimlikNo = txtTCKimlikNo.Text;
            SecilenHasta.Cinsiyet = cbCinsiyet.Text;
            SecilenHasta.CepTel = txtCepTelefonu.Text;
            SecilenHasta.EvTel = txtEvTelefonu.Text;
            SecilenHasta.KanGrubu = txtKanGrubu.Text;
            SecilenHasta.DogumTarihi = dtpDogumTarihi.Value;
            SecilenHasta.il = cbil.Text;
            SecilenHasta.Ilce = cbIlce.Text;
            SecilenHasta.KurumID = kurum.KurumID;
            SecilenHasta.Adres = txtAdres.Text;

            var result = _hastaService.Edit(SecilenHasta);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HastaListesiDoldur();
        }

        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            var result = _hastaService.Delete(SecilenHasta.HastaID);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), "İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HastaListesiDoldur();
        }
    }
}
