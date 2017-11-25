using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.BLL.Models
{
    interface IKurum
    {
        bool KurumKaydet(Kurumlar entity);
        bool KurumGuncelle(Kurumlar entity);
        bool KurumSil(Kurumlar entity);
    }
}
