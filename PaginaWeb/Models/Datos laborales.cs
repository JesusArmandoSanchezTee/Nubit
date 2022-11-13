using System.ComponentModel.DataAnnotations;

namespace PaginaWeb.Models
{
    public class Datos_laborales
    {
        [Key]
        public int Pkdatoslaborales { get; set; }
        public string Nombrempresa { get; set; }
        public string lugartrabajo { get; set; }

        public string puestoempeñado { get; set; }
        public string tiempoprestado { get; set; }
    }
}
