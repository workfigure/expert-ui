using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OHBDInnovationPlatform.Controllers
{
    public class DashboardsController : Controller
    {
        public IActionResult Dashboard_1()
        {
            return View();
        }
    }
}