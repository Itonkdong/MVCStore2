using MVCStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStore2.ViewModels
{
    public class ArtistAlbumViewModel
    {
        public Artist Artist { get; set; }
        public List<Album> Albums { get; set; }

        public ArtistAlbumViewModel(Artist artist, List<Album> albums)
        {
            Artist = artist;
            Albums = albums;
        }
    }
}