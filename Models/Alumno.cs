using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Platzi_ASP_NET_CORE.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        
        public string? CursoId{ get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        public Curso Curso{ get; set; }

        public List<Evaluación>? Evaluaciones { get; set; }
    }
}