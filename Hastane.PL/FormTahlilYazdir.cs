using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Microsoft.Reporting.WinForms;
using Ninject;

namespace Hastane.PL
{
    public partial class FormTahlilYazdir : Form
    {
        private readonly HastaKabul _secilenHasta;
        private readonly string _cbTahlillerSelectedValue;
        private readonly IHastaTahlilSonuclariRepository _hastaTahlilSonuclariRepository;

        public FormTahlilYazdir()
        {
            InitializeComponent();
        }

        public FormTahlilYazdir(HastaKabul secilenHasta, string cbTahlillerSelectedValue)
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _hastaTahlilSonuclariRepository = container.Get<IHastaTahlilSonuclariRepository>();
            _secilenHasta = secilenHasta;
            _cbTahlillerSelectedValue = cbTahlillerSelectedValue;
            InitializeComponent();
        }

        private void FormTahlilYazdir_Load(object sender, EventArgs e)
        {
            var data = _hastaTahlilSonuclariRepository.GetList(x => x.TahlilAdi==_cbTahlillerSelectedValue && x.KabulID==_secilenHasta.KabulID);
            this.HastaTahlilSonuclariBindingSource.DataSource = data;

            var p = new[]
            {
                new ReportParameter("AdSoyad",_secilenHasta.Hastalar.Ad+" "+ _secilenHasta.Hastalar.Soyad),
                new ReportParameter("Doktor",_secilenHasta.Personeller.Unvanlar.PersonelUnvan+ " "+_secilenHasta.Personeller.Ad+" "+_secilenHasta.Personeller.Soyad),
                new ReportParameter("Aciklama","-"),
                new ReportParameter("YapilanTest",_cbTahlillerSelectedValue),
                new ReportParameter("Cinsiyet",_secilenHasta.Hastalar.Cinsiyet),
                new ReportParameter("DogumTarihi",_secilenHasta.Hastalar.DogumTarihi.Value.ToShortDateString()),
                new ReportParameter("Klinik",_secilenHasta.Klinikler.KlinikAd),

            };
            reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
