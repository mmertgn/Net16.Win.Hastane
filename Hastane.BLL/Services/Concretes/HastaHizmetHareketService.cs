using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Models;
using Hastane.BLL.Services.Abstracts;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;

namespace Hastane.BLL.Services.Concretes
{
    public class HastaHizmetHareketService : IHastaHizmetHareketService
    {
        private readonly IHastaHizmetHareketRepository _hastaHizmetHareketRepository;

        public HastaHizmetHareketService(IHastaHizmetHareketRepository hastaHizmetHareketRepository)
        {
            _hastaHizmetHareketRepository = hastaHizmetHareketRepository;
        }

        public MessageResult Create(HastaHizmetHareketler model)
        {

            _hastaHizmetHareketRepository.Add(model);

            var m = new MessageResult
            {
                IsSucceed = true
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Ekleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Edit(HastaHizmetHareketler model)
        {
            throw new NotImplementedException();
        }

        public MessageResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<HastaHizmetHareketler> HizmetHareketList()
        {
            return _hastaHizmetHareketRepository.GetList(null);
        }

        public List<HastaHizmetHareketler> HizmetHareketListWithSorgu(Expression<Func<HastaHizmetHareketler, bool>> predicate)
        {
            return _hastaHizmetHareketRepository.GetList(predicate);
        }

        public HastaHizmetHareketler GetHizmetHareketById(int id)
        {
            return _hastaHizmetHareketRepository.FindById(id);
        }
    }
}
