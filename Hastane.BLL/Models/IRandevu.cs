using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Models
{
    interface IRandevu
    {
        List<Randevular> GetAllRandevu();
        Randevular GetRandevuByID(int ID);
        List<Randevular> RandevuBul(string HastaAdı, string HastaSoyadı, int HastaID);
        bool RandevuEkle(Randevular entity);
        bool RandevuGuncelle(Randevular entity);
        bool RandevuSil(Randevular silinen);
        bool RandevuSil(int ID);
    }
}
