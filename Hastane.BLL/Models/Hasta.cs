using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Models
{
    public class Hasta : IHasta
    {
        public List<Hastalar> GetAllHasta()
        {
            throw new NotImplementedException();
        }

        public Hastalar GetHastaByID(int ID)
        {
            throw new NotImplementedException();
        }

        public bool HastaEkle(Hastalar entity)
        {
            throw new NotImplementedException();
        }

        public bool HastaGuncelle(Hastalar entity)
        {
            throw new NotImplementedException();
        }

        public bool HastaKontrolByAdSoyad(string HastaAd, string HastaSoyad)
        {
            throw new NotImplementedException();
        }

        public bool HastaSil(Hastalar silinen)
        {
            throw new NotImplementedException();
        }

        public bool HastaSil(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
