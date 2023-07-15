﻿using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<MovieGenre> ?MovieGenres { get; set; }
    }
}
