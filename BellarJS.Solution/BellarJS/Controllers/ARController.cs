using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BellarJS.Controllers
{
    public class ARController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}