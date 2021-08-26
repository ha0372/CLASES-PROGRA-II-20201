using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaClase02.Models.ViewModel
{
    public class TblEmpleadoViewModel
    {
        public int id_empleado { get; set; }
        public string Empl_nombre { get; set; }
        public string Empl_apellido { get; set; }
        public string Empl_DUI { get; set; }
        public string Empl_direccion { get; set; }
        public string Empl_tel { get; set; }
        public string Empl_email { get; set; }
        public string Empl_cargo { get; set; }
    }
}