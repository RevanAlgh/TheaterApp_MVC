﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheaterApp.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        public string MovieTitle { get; set; }

        [Range(0, 10, ErrorMessage = "IMDB Rating must be between 0 and 10")]
        public float ImdbRating { get; set; }

        [Required(ErrorMessage = "Release year is required")]
        [Range(1900, 2100, ErrorMessage = "Year Released must be a valid year (1900 or later)")]
        public int YearReleased { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Budget must be a non-negative value")]
        public decimal Budget { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Box Office must be a non-negative value")]
        public decimal BoxOffice { get; set; }

        [MaxLength(20, ErrorMessage = "Language cannot exceed 20 characters")]
        public string Language { get; set; }

        public int AuthorID { get; set; }

        public ICollection<MovieAuthor> MovieAuthors { get; set; } = new Collection<MovieAuthor>();

        public Movie()
        {

        }
        public Movie(int movieID,
            string movieTitle,
            float imdbRating,
            int yearReleased,
            decimal budget,
            decimal boxOffice,
            string language,
            int authorID = 0)
        {
            MovieID = movieID;
            MovieTitle = movieTitle;
            ImdbRating = imdbRating;
            YearReleased = yearReleased;
            Budget = budget;
            BoxOffice = boxOffice;
            Language = language;
            AuthorID = authorID;
        }

        public void Update(string movieTitle,
            float imdbRating,
            int yearReleased,
            decimal budget,
            decimal boxOffice,
            string language,
            int authorID = 0)
        {
            this.MovieTitle = movieTitle;
            this.ImdbRating = imdbRating;
            this.YearReleased = yearReleased;
            this.Budget = budget;
            this.BoxOffice = boxOffice;
            this.Language = language;
            this.AuthorID = authorID;
        }

        public void Delete(string movieTitle,
            float imdbRating,
            int yearReleased,
            decimal budget,
            decimal boxOffice,
            string language,
            int authorID = 0)
        {
            this.MovieTitle = movieTitle;
            this.ImdbRating = imdbRating;
            this.YearReleased = yearReleased;
            this.Budget = budget;
            this.BoxOffice = boxOffice;
            this.Language = language;
            this.AuthorID = authorID;
        }

    }
}
