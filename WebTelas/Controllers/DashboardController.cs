using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTelas.Controllers
{
    //[Authorize]
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Home() // Views\Dashboard\"Home"
        {
            if( (bool)Session["UsuariorAuth"] == false)
            {
                return RedirectToAction("Login", "Frontend");
            }
            else
            {
                return View();
            }
        }
    }
}