using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;
using System.Linq;

namespace Salon.Controllers
{
  public class SylistsController : Controller
  {
    private readonly SalonContext _db;
    public StylistsController(SalonContext db)
    {
      _db = db;
    }
  }
}