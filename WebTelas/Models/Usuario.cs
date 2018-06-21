using System;
using System.Collections.Generic;

namespace WebTelas.Models
{
    
    public partial class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Contra { get; set; }

        public string Imagen { get; set; }
    

        public virtual Perfil Perfil { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
