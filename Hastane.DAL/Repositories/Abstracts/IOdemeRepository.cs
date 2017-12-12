using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;

namespace Hastane.DAL.Repositories.Abstracts
{
   public interface IOdemeRepository : IRepository<Odemeler>
    {

    }

    public class FaturaModel
    {
        public string HizmetAdi { get; set; }
        public decimal Tutar { get; set; }
    }
}
