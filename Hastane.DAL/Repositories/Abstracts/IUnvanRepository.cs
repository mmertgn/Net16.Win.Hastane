using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.DAL.Repositories.Abstracts
{
     public interface IUnvanRepository : IRepository<Unvanlar>
    {
        int GetUnvanCount();
        List<Unvanlar> UnvanGetir(string PersonelUnvan);
    }
}
