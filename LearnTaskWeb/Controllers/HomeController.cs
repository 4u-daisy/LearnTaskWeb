using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTaskWeb.Controllers
{
    //[ApiController, Route(template:"api/v1/name")]
    public class HomeController : Controller
    {
        //[HttpGet("home")]
        public IActionResult Page()
        {
            return View();
        }

    }
}
