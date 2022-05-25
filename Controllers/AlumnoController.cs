using Microsoft.AspNetCore.Mvc;
using Platzi_ASP_NET_CORE.Models;
using System.Linq;

namespace Platzi_ASP_NET_CORE.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            return View(_context.Alumnos.FirstOrDefault());
        }
        public IActionResult MultiAlumno()
        {       
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now.ToString();
            return View("MultiAlumno", _context.Alumnos);
        }
        
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
