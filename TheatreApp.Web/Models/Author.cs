﻿
using System.ComponentModel.DataAnnotations;
using TheaterApp.Models;

namespace MovieApi.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string AuthorName { get; set; }
        public ICollection<MovieAuthor> MovieAuthors { get; set; } = new List<MovieAuthor>();
    }
}