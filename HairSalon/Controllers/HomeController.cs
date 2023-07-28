using Microsoft.AspNetCore.Mvc;

namespace Salon.Solution.Controllers;

public class HomeController : Controller
{
  public ActionResult Index()
  {
    return View();
  }
}

