using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.BLL.Models;

namespace Hastane.BLL.Services.Abstracts
{
    public interface IPersonelService
    {
       
        MessageResult Create(Personeller model);
        List<Personeller> DoktorDoldurByKlinikFromRandevu(string cbKlinikText);
        List<PersonelListeleFromPersonel> PersonelListele();
        List<PersonelListeleOzel> PersonelleriOzelListele(string AdSoyad, string PersonelKod);
        Personeller GetPersonelFindById(int id);
        MessageResult Edit(Personeller model);
        MessageResult Delete(int id);
    }

    public class PersonelListeleOzel
    {
        public int PersonelID { get; set; }
        public int UnvanID { get; set; }
        public int KlinikID { get; set; }
        public string PersonelKod { get; set; }
        public string TCKNo { get; set; }
        public int SicilNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string EMail { get; set; }
        public string Adres { get; set; }
        public string EvTel { get; set; }
        public string CepTel { get; set; }
        public bool SilindiMi { get; set; }
    }

    public class PersonelListeleFromPersonel
    {
        public int PersonelID { get; set; }
        public int UnvanID { get; set; }
        public int KlinikID { get; set; }
        public string PersonelKod { get; set; }
        public string TCKNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int SicilNo { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string EMail { get; set; }
        public string Adres { get; set; }
        public string EvTel { get; set; }
        public string CepTel { get; set; }
        public bool SilindiMi { get; set; }
    }
}
