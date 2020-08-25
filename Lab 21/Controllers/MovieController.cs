using Lab_21.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lab_21.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Registration()
        {
            return View(new Movie());
        }

    

        public IActionResult Summary(Movie movie)
        {
            if(ModelState.IsValid)
            {
                return View(movie);
            }

            return View("Registration", movie);
        }
    }
}
