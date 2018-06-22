using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTelas.Controllers
{
    public class FrondEndController : Controller
    {
        // GET: FrondEnd
        public ActionResult PaginaFrond()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}