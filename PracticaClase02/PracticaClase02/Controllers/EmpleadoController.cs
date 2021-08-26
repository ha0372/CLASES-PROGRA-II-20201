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
        public ActionResult Save(int id, string nombre, string apellido, string dui, string direccion, string telefono, string correo, string cargo)
        {
            using (EMPLEADOSEntities emple = new EMPLEADOSEntities())
            {
                inventario empleado = new inventario();

                if (id == 0)
                {
                    empleado.Empl_nombre = nombre;
                    empleado.Empl_apellido = apellido;
                    empleado.Empl_DUI = dui;
                    empleado.Empl_direccion = direccion;
                    empleado.Empl_tel = telefono;
                    empleado.Empl_email = correo;
                    empleado.Empl_cargo = cargo;
                    emple.inventario.Add(empleado);
                    emple.SaveChanges();
                }
                else
                {
                    int update = id;
                    inventario editar = emple.inventario.Where(x=> x.id_empleado == update).FirstOrDefault();
                    editar.Empl_nombre = nombre;
                    editar.Empl_apellido = apellido;
                    editar.Empl_DUI = dui;
                    editar.Empl_direccion = direccion;
                    editar.Empl_tel = telefono;
                    editar.Empl_email = correo;
                    editar.Empl_cargo = cargo;
                    //emple.inventario.Add(empleado);
                    emple.SaveChanges();
                }
                
            }

            return Redirect("/Empleado/Empleado");
        }

        [HttpPost]
        public ActionResult EmpleadoSave(string nombre, string apellido, string dui, string direccion, string telefono, string correo, string cargo, int id= 0)
        {
            ViewBag.id = id;
            ViewBag.nombre = nombre;
            ViewBag.apellido = apellido;
            ViewBag.dui = dui;
            ViewBag.direccion = direccion;
            ViewBag.telefono = telefono;
            ViewBag.correo = correo;
            ViewBag.cargo = cargo;


            //= id;

            return View("EmpleadoSave");
        }

        //public ActionResult Edit(int id)
        //{


        //    ViewBag.id = id;
        //=id;
        //    return View("EmpleadoSave");
        //}

    }
}