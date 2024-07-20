﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheaterApp.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(20)]
        public string MovieTitle { get; set; }
        public float ImdbRating { get; set; }
        [Required]
        public int YearReleased { get; set; }
        public decimal Budget { get; set; }
        public decimal BoxOffice { get; set; }
        public string Language { get; set; }

        public int AuthorID { get; set; }

        public ICollection<MovieAuthor> MovieAuthors { get; set; } = new Collection<MovieAuthor>();
    }
}
