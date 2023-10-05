using Microsoft.AspNetCore.Mvc;
using PlacesVisited.Models;
using System.Collections.Generic;

namespace PlacesVisited.Controllers
{
  public class PlacesController: Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string countryName, string lengthOfStay, string companions, string journalEntry, string imageUrl)
    {
      Place newPlace = new Place(cityName, countryName, lengthOfStay, companions, journalEntry, imageUrl);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }
  }
}