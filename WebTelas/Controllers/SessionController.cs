using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTelas.Models;

namespace WebTelas.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                using (TelasDBContext db = new TelasDBContext())
                {
                    // var obj = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    //if (obj != null)
                    //{
                    //    Session["UserID"] = obj.UserId.ToString();
                    //    Session["UserName"] = obj.UserName.ToString();
                    //    return RedirectToAction("UserDashBoard");
                    //}

                    //db.Entry(usuario).State = EntityState.;
                    //db.SaveChanges();

                    var obj = db.Usuarios.Where(u => u.Nombre.Equals(usuario.Nombre) &&
                                                     u.Contra.Equals(usuario.Contra)).FirstOrDefault();
                    if( obj != null )
                    {
                        Session["UsuariorId"] = obj.Id.ToString();
                        Session["UsuariorNombre"] = obj.Nombre.ToString();
                        //Session["UsuariorrContra"] = obj.Contra.ToString();
                        Session["UsuariorPerfil"] = obj.Perfil.ToString();
                        Session["UsuariorImagen"] = obj.Imagen.ToString();

                        return RedirectToAction("Dashboard");
                    }
                }
                return RedirectToAction("Login");
            }
            return View(usuario);
        }
    }
}