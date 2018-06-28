using System;
using System.Collections.Generic;

namespace WebTelas.Models
{
    public partial class Tela
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public byte[] Imagen { get; set; }

        public double Costo { get; set; }
    }
}
