using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Models
{
    interface IUnvan
    {
        bool UnvanKaydet(Unvanlar entity);
        bool UnvanGuncelle(Unvanlar entity);
        bool UnvanSil(Unvanlar entity);
    }
}
