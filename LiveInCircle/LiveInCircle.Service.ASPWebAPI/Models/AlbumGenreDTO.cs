using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveInCircle.Service.ASPWebAPI.Models
{
    public class AlbumGenreDTO
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public string FullName { get; set; }
        public string GenreName { get; set; }

    }
}
