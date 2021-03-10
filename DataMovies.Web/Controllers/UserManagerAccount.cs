using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace GateMoviez.Web.Controllers
{
    [Authorize]
    public class UserManagerAccount : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Edite()
        {
            return View();

        }
        public IActionResult Favorite()
        {
            return View();

        }
        public IActionResult Profile()
        {
            return View();

        }
        public IActionResult Demand()
        {
            return View();

        }
        public IActionResult SellAccount()
        {
            return View();

        }
        public IActionResult SellAccountList()
        {
            return View();

        }
        public IActionResult Ticket()
        {
            return View();

        }
        public IActionResult TicketSend()
        {
            return View();

        }
        public IActionResult TicketSendsHistory()
        {
            return View();

        }
        public IActionResult TicketBack()
        {
            return View();

        }
    }
}
