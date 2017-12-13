using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Ninject;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Hastane.PL
{
    public partial class FormTahlilIslemleri : Form
    {
        private readonly ITahlilService _tahlilService;
        private readonly ITahlilRepository _tahlilRepository;
        private readonly ITahlilIcerikService _tahlilIcerikService;
        private readonly ITahlilIcerikRepository _tahlilIcerikRepository;
        private readonly IHastaKabulService _hastaKabulService;
        private readonly IHastaTahlilSonuclariRepository _hastaTahlilSonuclariRepository;

        private HastaKabul _secilenHasta;
        public FormTahlilIslemleri()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _tahlilService = container.Get<ITahlilService>();
            _tahlilRepository = container.Get<ITahlilRepository>();
            _tahlilIcerikRepository = container.Get<ITahlilIcerikRepository>();
            _tahlilIcerikService = container.Get<ITahlilIcerikService>();
            _hastaKabulService = container.Get<IHastaKabulService>();
            _hastaTahlilSonuclariRepository = container.Get<IHastaTahlilSonuclariRepository>();
            InitializeComponent();
        }


        private void btnTahlilOlustur_Click(object sender, EventArgs e)
        {
            var model = new Tahliller
            {
                TahlilAdi = txtTahlilAdi.Text,
                TahlilUcreti = Convert.ToDecimal(txtTahlilUcreti.Text)
            };

            var result = _tahlilService.Create(model);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, @"İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), @"İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TahlilDoldur();
        }

        private void FormTahlilIslemleri_Load(object sender, EventArgs e)
        {
            TahlilDoldur();
            TahlilIcerikDoldur();
            TahlilIstenenHastalarDoldur();
        }

        private void TahlilIstenenHastalarDoldur()
        {
            var model = _hastaKabulService.IstenenTahlilleriDoldur();
            dgvTahlilIstenenHastalar.DataSource = model;
            TahlilIstenenDataGridViewDuzenle();
        }

        private void TahlilIstenenDataGridViewDuzenle()
        {
            dgvTahlilIstenenHastalar.Columns[0].Visible = false;
            dgvTahlilIstenenHastalar.Columns[1].Visible = false;
            dgvTahlilIstenenHastalar.Columns[2].HeaderText = "Ad Soyad";
            dgvTahlilIstenenHastalar.Columns[3].HeaderText = "TC Kimlik No";
            dgvTahlilIstenenHastalar.Columns[4].HeaderText = "İstenen Tahliller";
            for (int i = 0; i < dgvTahlilIstenenHastalar.Columns.Count; i++)
            {
                dgvTahlilIstenenHastalar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void TahlilDoldur()
        {
            txtTahlilUcreti.Text = "0";
            cbTahliller.Clear();
            cbTahlillerAna.Clear();
            var model = _tahlilRepository.GetList();
            model.ForEach(item =>
                {
                    cbTahliller.AddItem(item.TahlilAdi);
                    cbTahlillerAna.AddItem(item.TahlilAdi);
                }
            );
            try
            {
                cbTahliller.selectedIndex = 0;
                cbTahlillerAna.selectedIndex = 0;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void btnTahlilIcerikEkle_Click(object sender, EventArgs e)
        {
            var tahlil = _tahlilRepository.TahlilGetir(cbTahlillerAna.selectedValue).FirstOrDefault();
            var model = new TahlilIcerik
            {
                TahlilIcerikAdi = txtTahlilIslemAdi.Text,
                TahlilIcerikReferansDegeri = txtTahlilReferansDegeri.Text,
                TahlilId = tahlil.TahlilID,
                TahlilIcerikSonuc = "",
                TahlilSonucBirimi = txtTahlilBirim.Text
            };
            var result = _tahlilIcerikService.Create(model);
            if (result.IsSucceed)
            {
                MessageBox.Show(result.SuccessMessage, @"İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(string.Join("\n", result.ErrorMessage), @"İşlem Gerçekleştirilemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TahlilIcerikDoldur();
        }

        private void TahlilIcerikDoldur()
        {
            lvlTahlilIcerikleri.Items.Clear();
            var tahlil = _tahlilRepository.TahlilGetir(cbTahlillerAna.selectedValue).FirstOrDefault();
            var model = _tahlilIcerikRepository.GetList(x => x.TahlilId == tahlil.TahlilID);
            model?.ForEach(item =>
                {
                    var lvi = new ListViewItem { Text = item.Tahliller.TahlilAdi };
                    lvi.SubItems.Add(item.TahlilIcerikAdi);
                    lvi.SubItems.Add(item.TahlilSonucBirimi);
                    lvi.SubItems.Add(item.TahlilIcerikReferansDegeri);
                    lvi.SubItems.Add(item.TahlilIcerikId.ToString());
                    lvlTahlilIcerikleri.Items.Add(lvi);
                }
            );
        }

        private void cbTahlillerAna_onItemSelected(object sender, EventArgs e)
        {
            TahlilIcerikDoldur();
        }

        private void btnTahlilIcerikSil_Click(object sender, EventArgs e)
        {
            if (lvlTahlilIcerikleri.SelectedIndices.Count > 0)
                _tahlilIcerikRepository.Delete(Convert.ToInt32(lvlTahlilIcerikleri.SelectedItems[0].SubItems[4].Text));

            TahlilIcerikDoldur();
        }

        private void dgvTahlilIstenenHastalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var _kabulId = dgvTahlilIstenenHastalar.CurrentRow.Cells[0].Value;
                _secilenHasta = _hastaKabulService.GetHastaKabulById(Convert.ToInt32(_kabulId));
                txtSeciliHasta.Text = _secilenHasta.Hastalar.Ad + " " + _secilenHasta.Hastalar.Soyad;


            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void cbTahliller_onItemSelected(object sender, EventArgs e)
        {
            var tahlil = _tahlilRepository.TahlilGetir(cbTahliller.selectedValue).FirstOrDefault();
            var model = _tahlilIcerikRepository.GetList(x => x.TahlilId == tahlil.TahlilID);

            dgvTahlilSonuclari.DataSource = model;
            TahlilSonuclariDataGridViewDuzenle();
        }

        private void TahlilSonuclariDataGridViewDuzenle()
        {
            dgvTahlilSonuclari.Columns[0].Visible = false;
            dgvTahlilSonuclari.Columns[1].HeaderText = "İşlem Adı";
            dgvTahlilSonuclari.Columns[4].Visible = false;
            dgvTahlilSonuclari.Columns[5].HeaderText = "Sonuç";
            dgvTahlilSonuclari.Columns[3].HeaderText = "Birim";
            dgvTahlilSonuclari.Columns[2].HeaderText = "Referans Değeri";
            dgvTahlilSonuclari.Columns[6].Visible = false;
            for (int i = 0; i < dgvTahlilIstenenHastalar.Columns.Count; i++)
            {
                dgvTahlilSonuclari.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnTahlilSonucKaydet_Click(object sender, EventArgs e)
        {
            if (_secilenHasta == null) return;
            
            for (var i = 0; i < dgvTahlilSonuclari.RowCount; i++)
            {
                var model = new HastaTahlilSonuclari
                {
                    Tarih = DateTime.Now.Date,
                    KabulID = _secilenHasta.KabulID,
                    TahlilAciklama = "-",
                    TahlilAdi = cbTahliller.selectedValue,
                    TahlilIcerikAdi = dgvTahlilSonuclari.Rows[i].Cells[1].Value.ToString(),
                    TahlilIcerikReferansDegeri = dgvTahlilSonuclari.Rows[i].Cells[2].Value.ToString(),
                    TahlilSonucBirimi = dgvTahlilSonuclari.Rows[i].Cells[3].Value.ToString(),
                    TahlilIcerikSonuc = dgvTahlilSonuclari.Rows[i].Cells[5].Value.ToString()
                };
                _hastaTahlilSonuclariRepository.Add(model);
            }
            MessageBox.Show("Tahlil Başarıyla Eklendi!", @"İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTahlilYapildiIsaretle_Click(object sender, EventArgs e)
        {
            if (_secilenHasta == null) return;
            _secilenHasta.TahlilYapildiMi = true;
            _hastaKabulService.Edit(_secilenHasta);
            MessageBox.Show("Hastanın Tüm Tahlilleri Doktora Gönderildi", "İşlem Gerçekleştirildi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TahlilIstenenHastalarDoldur();
        }
    }
}
