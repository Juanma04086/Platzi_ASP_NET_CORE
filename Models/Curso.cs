using System;
using System.Collections.Generic;


namespace Platzi_ASP_NET_CORE.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura>?Asignaturas{ get; set; }
        public List<Alumno>?Alumnos{ get; set; }

        public string? Dirección{ get; set; }
        public string? EscuelaId { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public Escuela Escuela { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
    }
}