using PracticaClase02.DAORe;
using PracticaClase02.Models;
using PracticaClase02.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaClase02.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        //[HttpPost]
        public ActionResult Descripcion(String variable)/*querystring*//*capturando la peticion desde la vista */
        {

            //var per = new clsPersona { Nombre = "William" };/*essto es una intruccion*/
            // return View(per);

            ViewBag.variableDinamica = variable;/*enviANDO ELEMENTO HJACIA LA VISTA */

            PersonaRepository per = new PersonaRepository();
            return View(per.obtenerPersona());
        }

        public ActionResult DescripcionViewModels(PersonaViewModel persona)
        {
            if (!ModelState.IsValid)
            {
                return View("PersonaViewModel",persona);
            }

            return Redirect("PersonaViewModel");
        }
        public ActionResult PersonaViewModel()
        {
            return View("");
        }

    }
}