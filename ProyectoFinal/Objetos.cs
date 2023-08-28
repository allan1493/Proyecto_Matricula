using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal
{
    public class Objetos
    {
    }
    public class oTipoIdentificacion
    {
        public int id { get; set; }
        public string tipoIdentificacion { get; set; }

    }

    public class oGenero
    {
        public int id { get; set; }
        public string genero { get; set; }

    }

    public class oEstadoCivil
    {
        public int id { get; set; }
        public string estado { get; set; }
    }

    public class oEstado
    {
        public int id { get; set; } 
        public string estado { get; set; }
    }

}