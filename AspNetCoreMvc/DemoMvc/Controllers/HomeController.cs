using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace DemoMvc.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            // ViewBag

            ViewBag.group = "P220";
            ViewBag.userName = "gabilgg07";
            ViewBag.numA = 5;
            ViewBag.numB = 7;

            // ViewData

            ViewData["value1"] = "deyer1";
            ViewData["value2"] = true;
            ViewData["valueA"] = 6;
            ViewData["valueB"] = 8;

            // yuxaridaki ikisi redirect zamani islemir...

            // TempData ise islreyir


            TempData["value4"] = "deyerTemp";
            TempData["value5"] = false;
            TempData["valueC"] = 54;
            TempData["valueD"] = 65;
            TempData["valueE"] = 43;

            return RedirectToAction("About");
            //return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult SendPerson()
        {
            var p = new Person()
            {
                Name = "Qabil",
                Surname = "Qurbanov"
            };

            ViewBag.Person = p;
            TempData["Person"] = p;

            var per = new Person()
            {
                Name = "Sahil",
                Surname = "Sedefli"
            };

            return View(per);
        }

        public IActionResult SendPersons()
        {
            var p = new Person()
            {
                Name = "Qabil",
                Surname = "Qurbanov"
            };

            var per = new Person()
            {
                Name = "Sahil",
                Surname = "Sedefli"
            };

            List<Person> people = new List<Person>();

            people.Add(p);
            people.Add(per);

            return View(people);
        }
    }
}

