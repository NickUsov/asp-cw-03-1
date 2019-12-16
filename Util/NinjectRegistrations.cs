using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using WebApplication6.Models;

namespace WebApplication6.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<BooksRepository>().InSingletonScope();
        }
    }
}