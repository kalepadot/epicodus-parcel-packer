using Microsoft.AspNetCore.Mvc;
using Shipping.Models;

namespace Shipping.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}