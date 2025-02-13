using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FactoryWeb.Models
{
    public class ComicMarvel
    {                   
        public int ComicFavoritoId { get; set; }
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Path { get; set; }
        public string? Extension { get; set; }        
    }
}
