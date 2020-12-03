using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveInCircle.UI.MVC.Models
{
    public class AlbumVM
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public string ArtistName { get; set; }
    }
}
