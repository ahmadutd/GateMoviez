using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace GateMoviez.Web.Controllers
{
    [Authorize]
    public class topimdbController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Series()
        {
            return View();
        }
    }
}
