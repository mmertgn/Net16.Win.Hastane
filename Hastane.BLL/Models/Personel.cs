using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Models
{
    public class Personel : IPersonel
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
            var Yonetici = db.SistemYoneticileri.Where(p => p.KullaniciAdi == KullaniciAdi && p.Sifre==Sifre).FirstOrDefault();
            if (Yonetici == null)
            {
                var Personel = db.Personeller.Where(p => p.KullaniciAdi == KullaniciAdi && p.Sifre == Sifre).FirstOrDefault();
                if (Personel == null)
                {
                    
                    return false;
                }
                else
                {
                    Genel.KullaniciAdi = Personel.Ad;
                    Genel.KullaniciSoyadi = Personel.Soyad;
                    return true;
                }
            }
            else
            {
                Genel.KullaniciAdi = Yonetici.Ad;
                Genel.KullaniciSoyadi = Yonetici.Soyad;
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
