using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [PrimaryKey(nameof(MovieId), nameof(GenreId))]
    public class MovieGenre
    {
        // Composite key properties
        [Column(Order = 0)]
        public int MovieId { get; set; }
        [Column(Order = 1)]
        public int GenreId { get; set; }

        // Navigation properties
        public Movie Movie { get; set; } = null!;
        public Genre Genre { get; set; } = null!;
    }
}
