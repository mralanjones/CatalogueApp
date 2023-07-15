using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [PrimaryKey(nameof(MovieId),nameof(ActorId))]
    public class MovieActor
    {
        // Composite key properties
        [Column(Order = 0)]
        public int MovieId { get; set; }
        [Column(Order = 1)]
        public int ActorId { get; set; }
        
        // Navigation properties
        public Movie Movie { get; set; } = null!;
        public Actor Actor { get; set; } = null!;
    }
}
