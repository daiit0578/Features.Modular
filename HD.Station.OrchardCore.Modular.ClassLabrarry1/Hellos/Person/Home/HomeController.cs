using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HD.Station.OrchardCore.Modular.ClassLabrarry1.Hellos.Person.Home
{
    public class HomeController : Controller
    {
        [Area("MeoMeo")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
