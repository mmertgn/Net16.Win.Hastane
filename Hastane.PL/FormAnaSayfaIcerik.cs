using Hastane.DAL.Repositories.Abstracts;
using Ninject;
using System;
using System.Windows.Forms;

namespace Hastane.PL
{
    public partial class FormAnaSayfaIcerik : Form
    {
        private readonly IPersonelRepository _personelRepository;
        private readonly ISistemYoneticisiRepository _sistemYoneticisiRepository;
        private readonly IKlinikRepository _klinikRepository;
        private readonly IHizmetRepository _hizmetRepository;
        private readonly ITahlilRepository _tahlilRepository;
        private readonly IKurumRepository _kurumRepository;
        private readonly IRandevuRepository _randevuRepository;

        public FormAnaSayfaIcerik()
        {
            var container = DependecyResolver.NinjectDependecyContainer.RegisterDependency(new StandardKernel());
            _personelRepository = container.Get<IPersonelRepository>();
            _sistemYoneticisiRepository = container.Get<ISistemYoneticisiRepository>();
            _klinikRepository = container.Get<IKlinikRepository>();
            _hizmetRepository = container.Get<IHizmetRepository>();
            _tahlilRepository = container.Get<ITahlilRepository>();
            _kurumRepository = container.Get<IKurumRepository>();
            _randevuRepository = container.Get<IRandevuRepository>();

            InitializeComponent();
        }

        private void FormAnaSayfaIcerik_Load(object sender, EventArgs e)
        {
            btnDoktorSayisi.LabelText = "Doktor : " + _personelRepository.GetDoktorCount();
            btnSekreterSayisi.LabelText = "Sekreter : " + _personelRepository.GetSekreterCount();
            btnYoneticiSayisi.LabelText = "Yönetici : " + _sistemYoneticisiRepository.GetSistemYoneticisiCount();
            btnKlinikSayisi.LabelText = "Klinikler : " + _klinikRepository.GetKlinikCount();
            btnHizmetSayisi.LabelText = "Hizmetler : " + _hizmetRepository.GetHizmetCount();
            btnTahlilSayisi.LabelText = "Tahliller : " + _tahlilRepository.GetTahlilCount();
            btnKurumSayisi.LabelText = "Kurumlar : " + _kurumRepository.GetKurumCount();
            btnRandevuSayisi.LabelText = "Randevular : " + _randevuRepository.GetRandevuCount();
        }
    }
}
