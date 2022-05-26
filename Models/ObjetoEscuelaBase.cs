using System;
using System.ComponentModel.DataAnnotations;

namespace Platzi_ASP_NET_CORE.Models
{
    public abstract class ObjetoEscuelaBase
    {
        
        public string Id { get; set; }
        public string Nombre { get; set; }

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public ObjetoEscuelaBase()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
           
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}