using System;
using System.ComponentModel.DataAnnotations;

namespace myLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}
