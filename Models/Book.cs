using System;
using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        public int GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Release date is required")]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 20, ErrorMessage = "Number in stock must be between 1 and 20")]
        [Required(ErrorMessage = "Number in stock is required")]
        public byte NumberInStock { get; set; }
    }
}
