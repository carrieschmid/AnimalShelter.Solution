using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimalShelter.Controllers
{
  public class BreedsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public BreedsController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Breeds> model = _db.Breeds.Include(breeds => breeds.Species).ToList();
      return View(model);
    }

    public ActionResult Details(int id)
    {
        Breeds thisBreed = _db.Breeds.FirstOrDefault(breeds => breeds.BreedsId == id);
        return View(thisBreed);
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Breeds breed)
    {
        _db.Breeds.Add(breed);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

  }
}