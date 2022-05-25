using Microsoft.AspNetCore.Mvc;
using Platzi_ASP_NET_CORE.Models;

namespace Platzi_ASP_NET_CORE.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;

        public IActionResult Index()
        {
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }
        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
    