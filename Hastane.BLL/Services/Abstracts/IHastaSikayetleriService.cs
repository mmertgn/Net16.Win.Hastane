using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Models;
using Hastane.DAL.DataModel;

namespace Hastane.BLL.Services.Abstracts
{
    public interface IHastaSikayetleriService
    {
        MessageResult Create(HastaSikayetleri model);
        MessageResult Edit(HastaSikayetleri model);
        HastaSikayetleri GetHastaSikayetleriByKabulId(int kabulId);
    }
}
