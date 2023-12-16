using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; } = null!;
        public int Year { get; set; }
        //public ICollection<MovieGenre> ?MovieGenres { get; set; }
    }
}
