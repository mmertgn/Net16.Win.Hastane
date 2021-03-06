﻿using Hastane.BLL.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Models;
using Hastane.DAL.DataModel;
using System.Linq.Expressions;
using Hastane.DAL.Repositories.Abstracts;
using Hastane.BLL.Validations;
using FluentValidation.Results;

namespace Hastane.BLL.Services.Concretes
{
    public class HastaService : IHastaService
    {
        private readonly IHastaRepository _repo;
        public HastaService(IHastaRepository repo)
        {
            _repo = repo;
        }
        public MessageResult Create(Hastalar model)
        {
            var _validator = new HastaAddValidator();
            ValidationResult result = _validator.Validate(model);
            if (result.IsValid)
            {
                _repo.Add(model);
            }
            var m = new MessageResult
            {
                ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                IsSucceed = result.IsValid
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Ekleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Delete(int id)
        {
            _repo.Delete(id);
            var m = new MessageResult
            {
                IsSucceed = true
            };
            m.SuccessMessage = m.IsSucceed == true ? "Kayıt Silme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
            return m;
        }

        public MessageResult Edit(Hastalar model)
        {
            var kontrol = _repo.GetList(x => x.HastaID != model.HastaID && x.TCKimlikNo == model.TCKimlikNo).Count;
            if (Convert.ToBoolean(kontrol))
            {
                var msg = new MessageResult();
                msg.ErrorMessage = new List<string> { "Bu TC No ile Kayıtlı bir Hasta zaten var." };
                return msg;
            }
            else
            {
                var _validator = new HastaUpdateValidator();
                ValidationResult result = _validator.Validate(model);
                if (result.IsValid)
                {
                    _repo.Update(model);
                }
                var m = new MessageResult
                {
                    ErrorMessage = result.Errors.Select(x => x.ErrorMessage).ToList(),
                    IsSucceed = result.IsValid
                };
                m.SuccessMessage = m.IsSucceed == true ? "Kayıt Güncelleme İşlemi Başarılı." : "Hatalı bilgiler mevcut";
                return m;
            }

        }

        public Hastalar GetHastaById(int id)
        {
            return _repo.FindById(id);
        }

        public List<HastaListesiModelFromRandevuIslemleri> HastaBilgileriDoldur()
        {
            var model = _repo.GetList().Select(x => new HastaListesiModelFromRandevuIslemleri
            {
                HastaId = x.HastaID,
                AdSoyad = x.Ad + " " + x.Soyad,
                TCNo = x.TCKimlikNo,
                CepTel = x.CepTel,
                Kurum = x.Kurumlar.KurumAd
            }).ToList();
            return model;
        }

        public List<HastaListesiModelFromRandevuIslemleri> HastaBilgileriDoldurAra(string HastaAdSoyad, string CepTel, string TcKimlikNo)
        {
            var model = _repo.GetList(x => (x.Ad + " " + x.Soyad).Contains(HastaAdSoyad) && x.CepTel.Contains(CepTel) && x.TCKimlikNo.Contains(TcKimlikNo))
                .Select(x => new HastaListesiModelFromRandevuIslemleri
                {
                    HastaId = x.HastaID,
                    AdSoyad = x.Ad + " " + x.Soyad,
                    TCNo = x.TCKimlikNo,
                    CepTel = x.CepTel,
                    Kurum = x.Kurumlar.KurumAd
                }).ToList();
            return model;
        }

        public List<Hastalar> HastaList()
        {
            return _repo.GetList(null);
        }


        public List<Hastalar> HastaListWithSorgu(Expression<Func<Hastalar, bool>> predicate)
        {
            return _repo.GetList(predicate);
        }
    }

}
