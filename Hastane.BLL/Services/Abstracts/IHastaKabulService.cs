using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Models;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Services.Abstracts
{
    public interface IHastaKabulService
    {
        MessageResult Edit(HastaKabul model);
        HastaKabul GetHastaKabulById(int id);
        MessageResult Create(HastaKabul model);
        List<HastaKabulModelFromDoktorIslemleri> DoktorRandevularıDoldur();
        List<HastaKabulModelFromDoktorIslemleri> DoktorRandevularıDoldurAra(string HastaAdSoyad, string CepTel, string TcKimlikNo);
        List<HastaKabulModelFromTahlilIslemleri> IstenenTahlilleriDoldur();
    }
    public class HastaKabulModelFromDoktorIslemleri //DoktorİşlemleriSayfasındakiDataGridViewBuModeleGöre doldurulacak
    {
        public int KabulId { get; set; }
        public int HastaId { get; set; }
        public int PersonelId { get; set; }
        public string AdSoyad { get; set; }
        public string TCKimlikNo { get; set; }
        public string CepTel { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public int Yas { get; set; }
        public string KanGrubu { get; set; }
        public string SigortaKurumu { get; set; }
        public string KlinikAdi { get; set; }
        public string DoktorAdi { get; set; }

    }

    public class HastaKabulModelFromTahlilIslemleri //TahlilİşlemleriSayfasındakiDataGridViewBuModeleGöre doldurulacak
    {
        public int KabulId { get; set; }
        public int HastaId { get; set; }
        public string AdSoyad { get; set; }
        public string TCKimlikNo { get; set; }
        public string IstenenTahliller { get; set; }

    }
}
