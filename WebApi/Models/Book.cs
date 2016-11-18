using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string PublishingHouse { get; set; }

        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public Genre genre { get; set; }
    }
}