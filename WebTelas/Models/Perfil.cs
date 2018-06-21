using System;
using System.Collections.Generic;

namespace WebTelas.Models
{
    public enum Nombre
    {
        ADMINISTRADOR, USUARIO
    }

    public partial class Perfil
    {
        public int Id { get; set; }

        public Nombre Nombre { get; set; }
    }
}
