using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTaskWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Page()
        {
            return View();
        }
    }
}
