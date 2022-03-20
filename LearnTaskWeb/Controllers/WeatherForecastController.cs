using LearnTaskWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LearnTaskWeb.Controllers
{
    public class WeatherForecastController : Controller
    {
        public IActionResult WeatherPage()
        {
            return View();
        }
    }
}
