using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMvc.Controllers
{
    public class PeopleController : Controller
    {

        static List<Person> people = new List<Person>()
        {
            new Person{Name= "Hesen", Surname = "Fikretov" },
            new Person{Name = "Malik",Surname = "Nusretli" }
        };

        static List<Profession> professions = new List<Profession>()
        {
            new Profession("Developer"),
            new Profession("Data Administrator"),
            new Profession("News Reporter"),
            new Profession("Physical therapist")
        };

        public IActionResult Index()
        {
            return View(people);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Professions = new SelectList(professions, "Id", "Name");
            return View();
        }

        [HttpPost]
        //public IActionResult Create(string name, string surname, int age)
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {

                //var p = new Person
                //{
                //    Name = name,
                //    Surname = surname,
                //    Age = age
                //}

                person.Profession = professions.FirstOrDefault(p => p.Id == person.ProfessionId);

                people.Add(person);

                return RedirectToAction("Index");
            }

            ViewBag.Professions = new SelectList(professions, "Id", "Name", person.ProfessionId);

            return View(person);

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

