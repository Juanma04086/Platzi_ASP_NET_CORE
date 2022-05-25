using Microsoft.AspNetCore.Mvc;
using Platzi_ASP_NET_CORE.Models;

namespace Platzi_ASP_NET_CORE.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            return View(new Asignatura
            {
                Nombre = "Programacion",
                Id = Guid.NewGuid().ToString()
            });
        }
    
    
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>()
                {
                            new Asignatura{Nombre="Matemáticas",
                            Id=Guid.NewGuid().ToString()
                            } ,
                            new Asignatura{Nombre="Educación Física",
                             Id=Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Castellano",
                             Id=Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Ciencias Naturales",
                            Id=Guid.NewGuid().ToString()
                            },
                            new Asignatura{Nombre="Programacion",
                            Id=Guid.NewGuid().ToString()
                            }
                };
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now.ToString();
                return View("MultiAsignatura",listaAsignaturas);
        }

    }
}
