using Hastane.BLL.Models;
using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;

namespace Hastane.BLL.Services.Abstracts
{
    public interface IRandevuService
    {
        MessageResult Edit(Randevular model);
        Randevular GetRandevuById(int id);
        MessageResult Create(Randevular model);
        List<string> DoktoraAitRandevular(string cbDoktorSelectedValue, DateTime RandevuTarihi);
        List<RandevuListeleFromHastaKabul>RandevuListele();
        List<RandevuListeleFromHastaKabul> RandevuListesiAra(string AdSoyad, string TcKimlikNo);
    }
    public class RandevuListeleFromHastaKabul 
    {
        public int RandevuId { get; set; }
        public int HastaId { get; set; }
        public int PersonelId { get; set; }
        public string Saat { get; set; }
        public string AdSoyad { get; set; }
        public string DoktorAdi { get; set; }
        public string TCKimlikNo { get; set; }
        public string KlinikAdi { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public bool GeldiMi { get; set; }
    }
}
