using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Platzi_ASP_NET_CORE.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        [Key]
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}