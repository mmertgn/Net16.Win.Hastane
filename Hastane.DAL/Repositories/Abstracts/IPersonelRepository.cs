﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DAL.DataModel;

namespace Hastane.DAL.Repositories.Abstracts
{
    public interface IPersonelRepository : IRepository<Personeller>
    {
        int GetDoktorCount();
        int GetSekreterCount();

    }
}
