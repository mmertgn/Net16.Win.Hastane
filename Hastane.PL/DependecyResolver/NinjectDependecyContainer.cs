using System;
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


            kernel.Bind<IHastaService>().To<HastaService>();
            kernel.Bind<IHastaRepository>().To<HastaRepository>();

            kernel.Bind<IPersonelRepository>().To<PersonelRepository>();

            kernel.Bind<IMessaging>().To<SystemNetMailManager>();

            return kernel;
        }
    }
}
