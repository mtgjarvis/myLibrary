﻿using System;
using System.ComponentModel.DataAnnotations;

namespace myLibary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}
