using Microsoft.AspNetCore.Mvc;
using Shipping.Models;
using System.Collections.Generic;

namespace Shipping.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpPost("/parcels")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Parcel newParcel = new Parcel(length, width, height, weight);
      newParcel.GetVolume();
      newParcel.GetCost();
      return RedirectToAction("Index", newParcel);
    }

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels); 
    }

  }
}