using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Models
{
    public class Personel
    {
        HastaneEntities db = new HastaneEntities(); 
        public List<Personeller> GetAllPersonel()
        {
            throw new NotImplementedException();
        }

        public Personeller GetPersonelByID(int ID)
        {
            throw new NotImplementedException();
        }

        public bool PersonelEkle(Personeller entity)
        {
            throw new NotImplementedException();
        }

        public bool PersonelGuncelle(Personeller entity)
        {
            throw new NotImplementedException();
        }

        public bool PersonelKontrolByAdSoyad(string PersonelAd, string PersonelSoyad)
        {
            throw new NotImplementedException();
        }

        public bool UyeGirisi(string KullaniciAdi, string Sifre)
        {
            var yonetici = db.SistemYoneticileri.FirstOrDefault(p => p.KullaniciAdi == KullaniciAdi && p.Sifre==Sifre);
            if (yonetici == null)
            {
                var personel = db.Personeller.FirstOrDefault(p => p.KullaniciAdi == KullaniciAdi && p.Sifre == Sifre);
                if (personel == null)
                {
                    
                    return false;
                }
                else
                {
                    Genel.KullaniciAdi = personel.Ad;
                    Genel.KullaniciSoyadi = personel.Soyad;
                    return true;
                }
            }
            else
            {
                Genel.KullaniciAdi = yonetici.Ad;
                Genel.KullaniciSoyadi = yonetici.Soyad;
                return true;
            }
        }
        

        public bool PersonelSil(Personeller silinen)
        {
            throw new NotImplementedException();
        }

        public bool PersonelSil(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
