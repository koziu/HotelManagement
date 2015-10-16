using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoExecutor.Core.QueryFactory.Infrastructure;
using HotelManagement.DataAccess.AdoExecutor;
using HotelManagement.DataAccess.Configuration;
using Ninject.Modules;

namespace HotelManagement.DataAccess.Modules
{
  [ExcludeFromCodeCoverage]
  public class InfrastructureModule : NinjectModule
  {
    public override void Load()
    {
      Bind<IQueryFactory>().To<HotelManagementDatabaseQueryFactory>();
      Bind<IConfiguration>().To<HotelMangamentConfiguration>().WhenInjectedInto<HotelManagementDatabaseQueryFactory>();
    }
  }
}
