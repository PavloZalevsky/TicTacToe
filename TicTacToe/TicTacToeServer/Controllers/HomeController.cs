using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicTacToeServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult TicTacToe()
        {
            return View();
        }
    }
}