using System.ComponentModel.DataAnnotations;

namespace PaginaWeb.Models
{
    public class Perfil_de_trabajo
    {
        [Key]
        public int PkPt { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    }
}
