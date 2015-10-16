using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DataAccess.DataAccess;
using HotelManagement.DataAccess.DataAccess.Interfaces;
using Ninject.Modules;

namespace HotelManagement.DataAccess.Modules
{
  [ExcludeFromCodeCoverage]
  public class DataAccessModule : NinjectModule
  {

    public override void Load()
    {
      //Repositories bind
      Bind<IClientRepositories>().To<ClientRepositories>();
    }
  }
}
