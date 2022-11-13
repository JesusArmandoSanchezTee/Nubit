using System.ComponentModel.DataAnnotations;
using System;

namespace PaginaWeb.Models
{
    public class Datos_personales
    {
        [Key]
        public int Pkdatospersonales { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string nacionalidad { get; set; }

        public DateTime fechanacimiento { get; set; }

        public string telefono { get; set; }
    }
}
