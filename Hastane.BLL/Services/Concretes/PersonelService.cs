using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.BLL.Services.Concretes
{
    public class PersonelService : IPersonelService
    {
        private readonly IPersonelRepository _personelRepo;

        public PersonelService(IPersonelRepository personelRepo)
        {
            _personelRepo = personelRepo;
        }
    }
}
