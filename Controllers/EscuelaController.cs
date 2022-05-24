using Microsoft.AspNetCore.Mvc;
using Platzi_ASP_NET_CORE.Models;

namespace Platzi_ASP_NET_CORE.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre =  " Platzi School";
            escuela.Ciudad =  " Bogota";
            escuela.Pais =  " Colombia";
            escuela.Dirección = " Avda siempre viva";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
                return View(escuela);
        }

    }
}
