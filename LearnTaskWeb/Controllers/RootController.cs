using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace LearnTaskWeb.Controllers
{
    public class RootController : Controller
    {
        //public IActionResult Person() => View(model: new List<Person> { new Person { Name = "sss", Age = 12 } });

        public IActionResult Index()
        {
            return View();
        }
    }
}
