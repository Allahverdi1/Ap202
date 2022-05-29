using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProniaTask.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaTask.Controllers
{
    public class HomeController : Controller
    {
        private AppContext _context { get; }

        public HomeController(AppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

     
    }
}
