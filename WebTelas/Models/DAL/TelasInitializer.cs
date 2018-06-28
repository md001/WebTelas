using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTelas.Models.DAL
{
    public class TelasInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TelasDBContext>
    {
        protected override void Seed(TelasDBContext context)
        {
            var usuarios = new List<Usuario>
            {
                new Usuario{Nombre="mario",Contra="mario",Imagen="Sin imagen"}
            };

            usuarios.ForEach(usr => context.Usuarios.Add(usr));
            context.SaveChanges();

            var perfiles = new List<Perfil>
            {
                new Perfil{Nombre=Nombre.ADMINISTRADOR}
            };

            perfiles.ForEach(prf => context.Perfiles.Add(prf));
            context.SaveChanges();

            var emps = new List<Empleado>
            {
                new Empleado{Nombre="Mario Didier", ApellidoP="Granados", ApellidoM="Vázquez"}
            };

            emps.ForEach(emp => context.Empleados.Add(emp));
            context.SaveChanges();

            var telas = new List<Tela>
            {
                new Tela{Nombre="Algodón 1", Descripcion="Tela nacional", Costo=30.0, Imagen=System.IO.File.ReadAllBytes("~\\Content\\images\\img-header\\slider-img-1.jpg")}
            };

            telas.ForEach(t => context.Telas.Add(t));
            context.SaveChanges();
        }
    }
}