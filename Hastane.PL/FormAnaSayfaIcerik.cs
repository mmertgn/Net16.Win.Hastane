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
using Hastane.DAL.Repositories.Abstracts;
using Ninject;

namespace Hastane.PL
{
    public partial class FormAnaSayfaIcerik : Form
    {
        private readonly IPersonelRepository _personelRepository;

        public FormAnaSayfaIcerik()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _personelRepository = container.Get<IPersonelRepository>();
            InitializeComponent();
        }

        private void FormAnaSayfaIcerik_Load(object sender, EventArgs e)
        {
            btnDoktorSayisi.LabelText = "Doktor : " + _personelRepository.GetDoktorCount();
            btnSekreterSayisi.LabelText = "Sekreter : " + _personelRepository.GetSekreterCount();
        }
    }
}
