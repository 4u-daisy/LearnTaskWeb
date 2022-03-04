using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTaskWeb.Controllers
{
    public class ListOfGaysController : Controller
    {
        public IActionResult People()
        {
            return View();
        }
    }
}
