using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OHBDInnovationPlatform.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult DataTables()
        {
            return View();
        }
    }
}