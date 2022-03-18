using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMP_1005_Security_App.Areas.Shopping.Controllers
{
    [Area("Shopping")]
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
