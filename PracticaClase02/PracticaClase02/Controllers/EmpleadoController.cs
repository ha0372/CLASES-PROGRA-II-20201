using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaClase02.Models;

namespace PracticaClase02.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Empleado()
        {
            using (EMPLEADOSEntities Empleado = new EMPLEADOSEntities())
            {
                var listEmpleado = Empleado.inventario.ToList();

                return View(listEmpleado);
            }
        }

        public ActionResult Delete(int id)
        {
            using (EMPLEADOSEntities emple = new EMPLEADOSEntities())
            {
                inventario eliminarEmpleado = emple.inventario.Where(x => x.id_empleado == id).FirstOrDefault();

                emple.inventario.Remove(eliminarEmpleado);
                emple.SaveChanges();
                //return View(listEmpleado);
            }

            return Redirect("/Empleado/Empleado");
        }


        [HttpPost]
        public ActionResult Save(string nombre)
        {
            using (EMPLEADOSEntities emple = new EMPLEADOSEntities())
            {
                inventario empleado = new inventario();

                empleado.Empl_nombre = nombre;
                emple.inventario.Add(empleado);
                emple.SaveChanges();
            }

            return Redirect("/Empleado/Empleado");
        }
    }
}