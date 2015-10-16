using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Mvc.Conventers.Interfaces
{
  public interface IConventer<in TSource, out TDestination>
  {
    TDestination Convert(TSource source);
  }
}
