using System.ComponentModel.DataAnnotations;

namespace PaginaWeb.Models
{
    public class Datos_domicilio
    {
        [Key]
        public int Pkdatosdomicilio { get; set; }
        public string direccion { get; set; }
        public string cp { get; set; }
        public string referencia { get; set; }
    }
}
