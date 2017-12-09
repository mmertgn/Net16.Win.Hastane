using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Models;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Services.Abstracts
{
    public interface IReceteDetayService
    {
        MessageResult Create(ReceteDetay model);
        List<ReceteDetayModel> ReceteDetayListesi(int receteId);
    }

    public class ReceteDetayModel
    {
        public int ReceteDetayId { get; set; }
        public string IlacAd { get; set; }
        public string IlacKullanimSikligi { get; set; }
    }
}
