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
    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string locationInput, string dateInput)
    {
      Place myPlace = new Place( locationInput, dateInput );
      return RedirectToAction("Index");
    }
    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }
  }
}
    //Next, create an index.cshtml file under Places to show places that have been created by user.
