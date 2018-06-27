using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTelas.Controllers
{
    public class FrontEndController : Controller
    {
        // GET: FrondEnd
        public ActionResult Index()
        {
            Session["UsuariorAuth"] = false;
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}