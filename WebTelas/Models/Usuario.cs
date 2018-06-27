using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebTelas.Models
{
    
    public partial class Usuario
    {
        //[Key]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Nombre de usuario requerido")]
        //[StringLength(16, MinimumLength = 6, ErrorMessage = "M�nimo 6 caracteres, m�ximo 16")]
        public string Nombre { get; set; }

        //[DataType(DataType.Password)]
        //[Required(ErrorMessage = "Contrase�a requerida")]
        //[MaxLength(30, ErrorMessage = "M�ximo 30 caracteres")]
        //[StringLength(31, MinimumLength = 7, ErrorMessage = "M�nimo 7 caracteres")]
        public string Contra { get; set; }

        public string Imagen { get; set; }
    

        public virtual Perfil Perfil { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}
