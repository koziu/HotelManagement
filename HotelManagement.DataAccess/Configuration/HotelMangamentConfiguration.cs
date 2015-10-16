using System.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace HotelManagement.DataAccess.Configuration
{
  [ExcludeFromCodeCoverage]
  public class HotelMangamentConfiguration : IConfiguration
  {
    public string EncodedConnectionString
    {
      get { return ConfigurationManager.ConnectionStrings["HotelManagement"].ConnectionString; }
    } 
  }
}
