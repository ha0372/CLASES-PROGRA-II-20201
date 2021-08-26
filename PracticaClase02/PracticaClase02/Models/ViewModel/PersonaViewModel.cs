using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaClase02.Models.ViewModel
{
    public class PersonaViewModel /*validaciones*/
    {
        [Display (Name ="ID")]
        [Range(0,int.MaxValue, ErrorMessage ="No Valido")]

        public int Id { get; set; }
        [Display (Name ="Nombre")]
        [Required(ErrorMessage ="Este campo es requerido")]
        public String Nombre { get; set; }
    }
}