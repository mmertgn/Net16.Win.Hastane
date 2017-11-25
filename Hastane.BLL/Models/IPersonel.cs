using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Models
{
    interface IPersonel
    {
        List<Personeller> GetAllPersonel();
        Personeller GetPersonelByID(int ID);
        bool PersonelKontrolByAdSoyad(string PersonelAd,string PersonelSoyad);
        bool PersonelEkle(Personeller entity);
        bool PersonelGuncelle(Personeller entity);
        bool PersonelSil(Personeller silinen);
        bool PersonelSil(int ID);
    }
}
