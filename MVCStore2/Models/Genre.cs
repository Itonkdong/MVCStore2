using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStore2.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }

        public Genre() { }

        public Genre(int genreId, string name, string description)
        {
            GenreId = genreId;
            Name = name;
            Description = description;
        }
    }
}