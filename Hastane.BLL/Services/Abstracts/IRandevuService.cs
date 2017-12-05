using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Services.Abstracts
{
   public interface IRandevuService
   {
       List<string> DoktoraAitRandevular(string cbDoktorSelectedValue, DateTime RandevuTarihi);
   }
}
