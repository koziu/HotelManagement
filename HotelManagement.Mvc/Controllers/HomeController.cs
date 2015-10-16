using System;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using HotelManagement.DataAccess.DataAccess.Interfaces;
using HotelManagement.Mvc.Helpers;
using HotelManagement.Mvc.Helpers.Interfaces;

namespace HotelManagement.Mvc.Controllers
{
  public class HomeController : Controller
  {
    private readonly IClientManager _clientManager;
    public HomeController(IClientManager clientManager)
    {
      _clientManager = clientManager;
    }
    public ActionResult Index()
    {
      var clientId = new Guid("0A8434E4-8BEB-48E7-9646-B2D06CB65865");
      return View(_clientManager.GetClientById(clientId));
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
