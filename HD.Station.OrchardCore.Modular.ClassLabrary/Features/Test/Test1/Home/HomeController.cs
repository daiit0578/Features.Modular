using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station.OrchardCore.Modular.ClassLabrary.Features.Test.Test1.Home
{
    [Area("Hello")]
    public class HomeController:Controller
    {
       public IActionResult Index()
        {
            return View();
        }
    }
}
