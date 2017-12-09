﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Infrastructure.Messaging.Abstracts;
using Hastane.BLL.Infrastructure.Messaging.SystemNetMail;
using Hastane.BLL.Services.Abstracts;
using Hastane.BLL.Services.Concretes;
using Hastane.DAL.DataModel;
using Hastane.DAL.Repositories.Abstracts;
using Hastane.DAL.Repositories.Concretes;
using Ninject;

namespace Hastane.PL.DependecyResolver
{
    public static class NinjectDependecyContainer
    {
        public static int HastaneEntities { get; private set; }

        public static IKernel RegisterDependency(IKernel kernel)
        {
            kernel.Bind<DbContext>().To<HastaneEntities>();

            kernel.Bind<IILRepository>().To<IlRepository>();
            kernel.Bind<IIlceRepository>().To<IlceRepository>();

            kernel.Bind<IHastaService>().To<HastaService>();
            kernel.Bind<IHastaRepository>().To<HastaRepository>();

            kernel.Bind<IPersonelRepository>().To<PersonelRepository>();
            kernel.Bind<IPersonelService>().To<PersonelService>();

            kernel.Bind<ISistemYoneticisiRepository>().To<SistemYoneticisiRepository>();

            kernel.Bind<IKlinikRepository>().To<KlinikRepository>();
            kernel.Bind<IKlinikService>().To<KlinikService>();

            kernel.Bind<IHizmetRepository>().To<HizmetRepository>();
            kernel.Bind<IHizmetService>().To<HizmetService>();

            kernel.Bind<ITahlilRepository>().To<TahlilRepository>();

            kernel.Bind<IKurumRepository>().To<KurumRepository>();
            kernel.Bind<IKurumService>().To<KurumService>();

            kernel.Bind<IUnvanRepository>().To<UnvanRepository>();
            kernel.Bind<IUnvanService>().To<UnvanService>();

            kernel.Bind<IRandevuRepository>().To<RandevuRepository>();
            kernel.Bind<IRandevuService>().To<RandevuService>();

            kernel.Bind<IHastaKabulRepository>().To<HastaKabulRepository>();
            kernel.Bind<IHastaKabulService>().To<HastaKabulService>();

            kernel.Bind<IHastaSikayetleriService>().To<HastaSikayetleriService>();
            kernel.Bind<IHastaSikayetleriRepository>().To<HastaSikayetleriRepository>();

            kernel.Bind<ITeshisService>().To<TeshisService>();
            kernel.Bind<ITeshisRepository>().To<TeshisRepository>();

            kernel.Bind<IReceteService>().To<ReceteService>();
            kernel.Bind<IReceteRepository>().To<ReceteRepository>();

            kernel.Bind<IReceteDetayRepository>().To<ReceteDetayRepository>();
            kernel.Bind<IReceteDetayService>().To<ReceteDetayService>();

            kernel.Bind<IHastaHizmetHareketRepository>().To<HastaHizmetHareketRepository>();
            kernel.Bind<IHastaHizmetHareketService>().To<HastaHizmetHareketService>();

            kernel.Bind<IMessaging>().To<SystemNetMailManager>();

            return kernel;
        }
    }
}
