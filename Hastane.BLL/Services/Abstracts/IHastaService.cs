using Hastane.BLL.Models;
using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Services.Abstracts
{
    public interface IHastaService
    {
        MessageResult Create(Hastalar model);
        MessageResult Edit(Hastalar model);
        MessageResult Delete(int id);
        List<Hastalar> HastaList();
        List<Hastalar> HastaListWithSorgu(Expression<Func<Hastalar, bool>> predicate);
        Hastalar GetHastaById(int id);
        List<HastaListesiModelFromRandevuIslemleri> HastaBilgileriDoldur();
        List<HastaListesiModelFromRandevuIslemleri> HastaBilgileriDoldurAra(string HastaAdSoyad, string CepTel, string TcKimlikNo);
    }

    public class HastaListesiModelFromRandevuIslemleri
    {
        public int HastaId { get; set; }
        public string AdSoyad { get; set; }
        public string TCNo { get; set; }
        public string CepTel { get; set; }
        public string Kurum { get; set; }
    }
}
