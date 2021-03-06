using System;
using System.Collections.Generic;

namespace BlazorCatalogoMusica.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Descripcion { get; set; }
        public byte[] CoverImage { get; set; }
        public string Author { get; set; }
        public List<Song> Songs { get; set; }
    }
}
