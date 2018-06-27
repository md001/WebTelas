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
                    //var obj = db.Usuarios
                    //            .Where(u => u.Nombre.Equals(usuario.Nombre));
                    var usrList = (from u in db.Usuarios
                                   where u.Nombre == usuario.Nombre
                                   select u).ToList();

                    if (usrList != null) 
                    {
                        if (usrList.Count<Usuario>() == 1)
                        {
                            Usuario u = usrList.First<Usuario>();
                            Session["UsuariorId"] = u.Id.ToString();
                            Session["UsuariorNombre"] = u.Nombre.ToString();
                            
                            //Session["UsuariorPerfil"] = u.Perfil.ToString();
                            //Session["UsuariorImagen"] = u.Imagen.ToString();

                            return RedirectToAction("Home", "Dashboard");
                        }
                        else
                        {
                            // más de un usuario!
                            return RedirectToAction("Index");
                        }
                    }
                    else
                    {
                        // nombre y/o contra inválido(s), indicar error
                        return RedirectToAction("Index");
                    }
                }
            }
            else
            {   // Debe de retornar a una página de error
                return RedirectToAction("Index", "Frontend");
            }
        }
    }
}