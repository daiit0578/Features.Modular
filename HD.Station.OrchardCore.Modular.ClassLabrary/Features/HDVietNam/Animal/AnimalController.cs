using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HD.Station.OrchardCore.Modular.ClassLabrary.Features.HDVietNam.Animal
{
    public class AnimalController:Controller
    {
        [Area("Animals")]
        //public IActionResult test()
        //{

        //    return Ok();
        //}
        public IActionResult Animal()
        {
            return View();
        }
    }
}
