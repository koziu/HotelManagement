using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DataAccess.Encryption
{
  [ExcludeFromCodeCoverage]
  public static class Decoder
  {
    public static string Decode(string value)
    {
      try
      {
        var key = new Guid("4D2BD4E6-7791-4396-BDBC-BC613124DCBF");
        var vi = new Guid("7B0A946A-80B4-4cd2-ACB5-ABE7CDE1A631");
        using (var rm = new RijndaelManaged { KeySize = 128, Key = key.ToByteArray(), IV = vi.ToByteArray() })
        {
          byte[] input = Convert.FromBase64String(value);
          byte[] encoded = rm.CreateDecryptor().TransformFinalBlock(input, 0, input.Length);
          var enc = new ASCIIEncoding();

          return enc.GetString(encoded);
        }

      }
      catch (Exception e)
      {
        throw new Exception(String.Format("[Fulcrum.Security.Cryptography.Decode]: {0}", e.Message), e);
      }
    }

  }
}
