﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMvc.Models.DataContext;
using DemoMvc.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DemoMvc.Controllers
{
    public class PeopleController : Controller
    {

        //static List<Person> people = new List<Person>()
        //{
        //    new Person{Name= "Hesen", Surname = "Fikretov" },
        //    new Person{Name = "Malik",Surname = "Nusretli" }
        //};

        //static List<Profession> professions = new List<Profession>()
        //{
        //    new Profession("Developer"),
        //    new Profession("Data Administrator"),
        //    new Profession("News Reporter"),
        //    new Profession("Physical therapist")
        //};

        readonly DemoDbContext db;

        public PeopleController(DemoDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            // replace with di(dependency injection)
            // DemoDbContext db = new DemoDbContext();

            List<Person> people = db.People.Include(p=>p.Profession).ToList();

            return View(people);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<Profession> professions = db.Professions.ToList();
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

                //person.Profession = professions.FirstOrDefault(p => p.Id == person.ProfessionId);

                //people.Add(person);

                db.People.Add(person);

                db.SaveChanges();

                return RedirectToAction("Index");
            }


            List<Profession> professions = db.Professions.ToList();
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

            //Person per = people.FirstOrDefault(p => p.Id == id);

            Person per = db.People.Include(p=>p.Profession).FirstOrDefault(p => p.Id == id);

            return View(per);
        }
    }
}

