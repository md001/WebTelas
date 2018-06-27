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
            Session["UsuariorAuth"] = false;

            if (ModelState.IsValid)
            {
                using (TelasDBContext db = new TelasDBContext())
                {
                    var usrList = db.Usuarios
                                    .Where(u => u.Nombre.Equals(usuario.Nombre) &&
                                                u.Contra.Equals(usuario.Contra));
                    //var usrList = (from   u in db.Usuarios
                    //               where  u.Nombre == usuario.Nombre &&
                    //                      u.Contra == usuario.Contra
                    //               select u).ToList();


                    if (usrList != null) 
                    {
                        if (usrList.Count<Usuario>() == 1)
                        {
                            Usuario u = usrList.First<Usuario>();
                            Session["UsuariorId"] = u.Id.ToString();
                            Session["UsuariorNombre"] = u.Nombre.ToString();
                            Session["UsuariorAuth"] = true;
                            //Session["UsuariorPerfil"] = u.Perfil.ToString();
                            //Session["UsuariorImagen"] = u.Imagen.ToString();

                            return RedirectToAction("Home", "Dashboard");
                        }
                        else
                        {
                            Session["UsuariorAuth"] = false;
                            // más de un usuario!
                            return RedirectToAction("Login", "Frontend");
                        }
                    }
                    else
                    {
                        Session["UsuariorAuth"] = false;
                        // nombre y/o contra inválido(s), indicar error
                        return RedirectToAction("Login", "Frontend");
                    }
                }
            }
            else
            {
                Session["UsuariorAuth"] = false;
                // Debe de retornar a una página de error
                return RedirectToAction("Index", "Frontend");
            }
        }
    }
}