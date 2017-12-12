using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Microsoft.Reporting.WinForms;
using Ninject;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hastane.PL
{
    public partial class FormFatura : Form
    {
        private readonly IHastaHizmetHareketRepository _hastaHizmetHareketRepository;
        private readonly HastaKabul _secilenHasta;
        private readonly double _genelToplam;

        public FormFatura()
        {
            InitializeComponent();
        }

        public FormFatura(HastaKabul secilenHasta, double _genelToplam)
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _hastaHizmetHareketRepository = container.Get<IHastaHizmetHareketRepository>();
            _secilenHasta = secilenHasta;
            this._genelToplam = _genelToplam;
            InitializeComponent();
        }

        private void FormFatura_Load(object sender, EventArgs e)
        {
            var data = _hastaHizmetHareketRepository.GetList(x => x.KabulID == _secilenHasta.KabulID).Select(x=> new FaturaModel
            {
                HizmetAdi = x.Hizmetler.HizmetAdi,
                Tutar = x.Tutar
            });
            this.FaturaModelBindingSource.DataSource = data;
            var date = DateTime.Now.ToShortDateString();

            var p = new[]
            {
                new ReportParameter("HastaAdSoyad",_secilenHasta.Hastalar.Ad+" "+ _secilenHasta.Hastalar.Soyad),
                new ReportParameter("TCKimlikNo",_secilenHasta.Hastalar.TCKimlikNo),
                new ReportParameter("DogumTarihi",_secilenHasta.Hastalar.DogumTarihi.Value.ToShortDateString()),
                new ReportParameter("Telefon",_secilenHasta.Hastalar.CepTel),
                new ReportParameter("Kurum",_secilenHasta.Hastalar.Kurumlar.KurumAd),
                new ReportParameter("Doktor",_secilenHasta.Personeller.Unvanlar.PersonelUnvan+ " "+_secilenHasta.Personeller.Ad+" "+_secilenHasta.Personeller.Soyad),
                new ReportParameter("IslemTarihi",date),
                new ReportParameter("GenelToplam",$"{_genelToplam:c}")
            };
            reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
