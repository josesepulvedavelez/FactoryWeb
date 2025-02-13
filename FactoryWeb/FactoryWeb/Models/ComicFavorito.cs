using static FactoryWeb.Models.Usuario;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FactoryWeb.Models
{
    public class ComicFavorito
    {
        [Key]
        public int ComicFavoritoId { get; set; }
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Path { get; set; }
        public string? Extension { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
    }
}
