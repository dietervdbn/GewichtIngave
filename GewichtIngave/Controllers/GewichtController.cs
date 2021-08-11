using GewichtIngave.Data;
using GewichtIngave.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GewichtIngave.Controllers
{
    public class GewichtController : Controller
    {
        GewichtDbContext Context;
        public GewichtController(GewichtDbContext context)
        {
            Context = context;
        }
        public IActionResult Index()
        {
            return View(Context.Wegingen);
        }
        public IActionResult Detail(int id)
        {
            var gewicht = Context.Wegingen.Where(a => a.Id == id);
            return View(gewicht.FirstOrDefault());
        }
        public IActionResult AddGewicht()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGewicht(GewichtModel Wage)
        {
            if (ModelState.IsValid)
            {
                Context.Wegingen.Add(Wage);
                Context.SaveChanges();
                int id = Wage.Id;
                return RedirectToAction("Detail", new { id = Wage.Id });
            }
            return View(Wage);
        }
    }
}

