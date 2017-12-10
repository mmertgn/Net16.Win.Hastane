﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.DAL.Repositories.Abstracts
{
   public interface ITahlilRepository : IRepository<Tahliller>
   {
       int GetTahlilCount();
       List<Tahliller> TahlilGetir(string TahlilAdi);
   }
}
