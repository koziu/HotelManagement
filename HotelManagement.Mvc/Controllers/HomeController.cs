using System;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;       

namespace HotelManagement.Mvc.Controllers
{
  public class HomeController : Controller
  {      
  
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      return View();
    }

    public ActionResult Contact()
    {
      return View();
    }
  }
}
