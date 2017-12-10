using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Models;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Services.Abstracts
{
    public interface ITahlilIcerikService
    {
        MessageResult Create(TahlilIcerik model);
    }
}
