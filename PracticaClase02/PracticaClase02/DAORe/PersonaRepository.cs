using PracticaClase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaClase02.DAORe
{
    public class PersonaRepository /*Esta claseRepositorio  va tener un metodo el cual nos va a retornar a nosotros  una lista de personas*/
    {

        public List<ClsPersona> obtenerPersona()
        {
            return new List<ClsPersona>()
            {
                new ClsPersona()/*las listas pero en formatos de objetos*/
                {
                    Id=1,
                    Nombre = "William"

                },
                new ClsPersona()
                {
                    Id= 2,
                    Nombre= "Carlos"
                },
                new ClsPersona()
                {
                    Id= 3,
                    Nombre= "Angel"
                }


            };/*solo que ahora se esta realizando dentro de un repoitory varias perssonas*/



        }
    }
}