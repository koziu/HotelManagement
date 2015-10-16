using System;
using System.Diagnostics.CodeAnalysis;
using AdoExecutor.Core.ConnectionString;
using AdoExecutor.Core.DataObjectFactory;
using AdoExecutor.Core.QueryFactory;
using HotelManagement.DataAccess.Configuration;
using HotelManagement.DataAccess.Encryption;

namespace HotelManagement.DataAccess.AdoExecutor
{
  [ExcludeFromCodeCoverage]
  public class HotelManagementDatabaseQueryFactory : QueryFactoryBase
  {
    private readonly IConfiguration _configuration;

    public HotelManagementDatabaseQueryFactory(IConfiguration configuration)
    {
      if (configuration == null)
      {
        throw new ArgumentException("configuration");
      }
      _configuration = configuration;
    }

    protected override void ConfigureConnectionStringProvider(global::AdoExecutor.Core.Configuration.Configuration configuration)
    {
      string encodedConnectionString = _configuration.EncodedConnectionString;
      string decodedConnectionString = Decoder.Decode(encodedConnectionString);
      configuration.ConnectionStringProvider = new ConstantConnectionStringProvider(decodedConnectionString);
    }

    protected override void ConfigureDataObjectFactory(global::AdoExecutor.Core.Configuration.Configuration configuration)
    {
      configuration.DataObjectFactory = new SqlDataObjectFactory();
    }
  }
}
