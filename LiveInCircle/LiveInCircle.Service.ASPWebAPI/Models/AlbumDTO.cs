using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveInCircle.Service.ASPWebAPI.Models
{
    public class AlbumDTO
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public string ArtistName { get; set; }
    }
}
