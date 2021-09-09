using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaClase02.Models;
using PracticaClase02.Models.ViewModel;

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


        //[HttpPost]
        //public ActionResult Save(string nombre, string apellido, string dui, string direccion, string telefono, string correo, string cargo)
        //{
        //    using (EMPLEADOSEntities emple = new EMPLEADOSEntities())
        //    {
        //        inventario empleado = new inventario();

        //        empleado.Empl_nombre = nombre;
        //        empleado.Empl_apellido = apellido;
        //        empleado.Empl_DUI = dui;
        //        empleado.Empl_direccion = direccion;
        //        empleado.Empl_tel = telefono;
        //        empleado.Empl_email = correo;
        //        empleado.Empl_cargo = cargo;
        //        emple.inventario.Add(empleado);
        //        emple.SaveChanges();
        //    }

        //    return Redirect("/Empleado/Empleado");
        //}
        [HttpPost]
        public ActionResult Save(TblEmpleadoViewModel epl/*int id, string nombre, string apellido, string dui, string direccion, string telefono, string correo, string cargo*/)
        {
            using (EMPLEADOSEntities emple = new EMPLEADOSEntities())
            {
                inventario empleado = new inventario();

                if (epl.id_empleado == 0)
                {
                    empleado.Empl_nombre = epl.Empl_nombre;
                    empleado.Empl_apellido = epl.Empl_apellido;
                    empleado.Empl_DUI = epl.Empl_DUI;
                    empleado.Empl_direccion = epl.Empl_direccion;
                    empleado.Empl_tel = epl.Empl_tel;
                    empleado.Empl_email = epl.Empl_email;
                    empleado.Empl_cargo = epl.Empl_cargo;
                    emple.inventario.Add(empleado);
                    emple.SaveChanges();
                }
                else
                {
                    int update = epl.id_empleado;
                    inventario editar = emple.inventario.Where(x=> x.id_empleado == update).FirstOrDefault();
                    editar.Empl_nombre = epl.Empl_nombre;
                    editar.Empl_apellido = epl.Empl_apellido;
                    editar.Empl_DUI = epl.Empl_DUI;
                    editar.Empl_direccion = epl.Empl_direccion;
                    editar.Empl_tel = epl.Empl_tel;
                    editar.Empl_email = epl.Empl_email;
                    editar.Empl_cargo = epl.Empl_cargo;
                    //emple.inventario.Add(empleado);
                    emple.SaveChanges();
                }
                
            }

            return Redirect("/Empleado/Empleado");
        }

        //[HttpPost]
        //public ActionResult EmpleadoSave(string nombre, string apellido, string dui, string direccion, string telefono, string correo, string cargo, int id= 0)
        //{
        //    ViewBag.id = id;
        //    ViewBag.nombre = nombre;
        //    ViewBag.apellido = apellido;
        //    ViewBag.dui = dui;
        //    ViewBag.direccion = direccion;
        //    ViewBag.telefono = telefono;
        //    ViewBag.correo = correo;
        //    ViewBag.cargo = cargo;


        //    //= id;

        //    return View("EmpleadoSave");
        //}

        [HttpPost]
        public ActionResult EmpleadoSave(String id)
        {
            inventario empleado = new inventario();

            using (EMPLEADOSEntities Empleado = new EMPLEADOSEntities())
            {
                
                int update = Convert.ToInt32(id);

                inventario cargarDatos = Empleado.inventario.Where(x => x.id_empleado == update).FirstOrDefault();

                return View(cargarDatos);
            }

            
        }

    }
}