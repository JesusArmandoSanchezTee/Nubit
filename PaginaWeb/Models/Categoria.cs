using System.ComponentModel.DataAnnotations;

namespace PaginaWeb.Models
{
    public class Categoria
    {
        [Key]
        public int PkCategoria { get; set; }
        public string Nombre { get; set; }
    }
}
