using System.ComponentModel.DataAnnotations;

namespace Peliculas.Models
{
    public class movie
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha_Lanzamieto { get; set; }
        public string Genero { get; set; }
        public decimal Precio { get; set; }
    }
}
