using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlacesBeen.Models;


namespace PlacesBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlace = Place.GetAll();
      return View(allPlace);
    }
  }
}

