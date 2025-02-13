using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FactoryWeb.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        public string? Nombre { get; set; }

        public string? Identificacion { get; set; }

        public string? Correo { get; set; }

        public string? UserName { get; set; }

        public string? Pass { get; set; }
    }
}
