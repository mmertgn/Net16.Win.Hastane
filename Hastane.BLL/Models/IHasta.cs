using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Models
{
    interface IHasta
    {
        List<Hastalar> GetAllHasta();
        Hastalar GetHastaByID(int ID);
        bool HastaKontrolByAdSoyad(string HastaAd, string HastaSoyad);
        bool HastaEkle(Hastalar entity);
        bool HastaGuncelle(Hastalar entity);
        bool HastaSil(Hastalar silinen);
        bool HastaSil(int ID);
    }
}
