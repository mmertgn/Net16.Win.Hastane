using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Microsoft.Reporting.WinForms;
using Ninject;
using System;
using System.Windows.Forms;

namespace Hastane.PL
{
    public partial class FormReceteYazdir : Form
    {
        private readonly HastaKabul _secilenHasta;
        private readonly int _receteId;
        private readonly Teshisler _teshis;
        private readonly IReceteDetayRepository _receteDetayRepository;

        public FormReceteYazdir()
        {
            InitializeComponent();
        }

        public FormReceteYazdir(HastaKabul secilenHasta, int receteId, Teshisler teshis)
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _receteDetayRepository = container.Get<IReceteDetayRepository>();
            _secilenHasta = secilenHasta;
            _receteId = receteId;
            _teshis = teshis;
            InitializeComponent();
        }

        private void FormReceteYazdir_Load(object sender, EventArgs e)
        {
            var data = _receteDetayRepository.GetList(x => x.ReceteID == _receteId);
            this.ReceteDetayBindingSource.DataSource = data;
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
                new ReportParameter("Teshis",_teshis.Teshis)
            };
            reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
