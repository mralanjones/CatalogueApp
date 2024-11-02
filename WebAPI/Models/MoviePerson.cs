using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [PrimaryKey(nameof(MovieId),nameof(PersonId))]
    public class MoviePerson
    {
        // Composite key properties
        [Column(Order = 0)]
        public int MovieId { get; set; }
        [Column(Order = 1)]
        public int PersonId { get; set; }
        
        // Navigation properties
        public Movie Movie { get; set; } = null!;
        public Person Person { get; set; } = null!;
    }
}
