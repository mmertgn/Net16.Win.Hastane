using Hastane.BLL.Models;
using Hastane.DAL.DataModel;
using System;
using System.Collections.Generic;

namespace Hastane.BLL.Services.Abstracts
{
    public interface IRandevuService
    {
        MessageResult Create(Randevular model);
        List<string> DoktoraAitRandevular(string cbDoktorSelectedValue, DateTime RandevuTarihi);
    }
}
