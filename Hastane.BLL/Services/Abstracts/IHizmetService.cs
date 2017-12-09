﻿using Hastane.BLL.Models;
using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Services.Abstracts
{
    public interface IHizmetService
    {
        MessageResult Create(Hizmetler model);
        MessageResult Edit(Hizmetler model);
        MessageResult Delete(int id);
        List<Hizmetler> HizmetList();
        List<Hizmetler> HizmetListWithSorgu(Expression<Func<Hizmetler, bool>> predicate);
        Hizmetler GetHizmetById(int id);
        List<HizmetListesiModelFromSistemYonetim> HizmetBilgisiDoldur();
        List<HizmetListesiModelFromSistemYonetim> HizmetBilgisiDoldurAra(string HizmetAd,string HizmetAciklama);
    }
    public class HizmetListesiModelFromSistemYonetim
    {
        public int HizmetId { get; set; }
        public string HizmetAd { get; set; }
        public int KlinikId { get; set; }
        public decimal Ucret { get; set; }
        public string HizmetAciklama { get; set; }
    }
}
