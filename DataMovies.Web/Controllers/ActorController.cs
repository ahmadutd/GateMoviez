using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace GateMoviez.Web.Controllers
{
    [Authorize]
    public class ActorController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
