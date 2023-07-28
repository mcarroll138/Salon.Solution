using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Salon.Solution.Models;

namespace Salon.Solution.Controllers;

public class HomeController : Controller
{
  public ActionResult Index()
  {
    return View();
  }
}

