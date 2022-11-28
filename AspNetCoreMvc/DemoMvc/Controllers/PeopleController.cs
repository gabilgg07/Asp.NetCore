using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers
{
    public class PeopleController : Controller
    {

        static List<Person> people = new List<Person>()
        {
            new Person("Hesen", "Fikretov"),
            new Person("Malik", "Nusretli")
        };

        public IActionResult Index()
        {
            return View(people);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, string surname)
        {
            var p = new Person(name, surname);

            people.Add(p);

            return RedirectToAction("Index");
        }

        // Model Bilding hem formdan oxuya bilir,
        // hem linkden:
        // route: /people/details/3;
        // hem de query:
        // query parametr: /people/details?id=3

        public IActionResult Details(int? id)
        {

            Person per = people.FirstOrDefault(p => p.Id == id);

            return View(per);
        }
    }
}

