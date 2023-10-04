using Microsoft.AspNetCore.Mvc;

namespace PlacesVisited.Controllers
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