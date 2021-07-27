using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudExamenn.Controllers
{
    public class SocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
