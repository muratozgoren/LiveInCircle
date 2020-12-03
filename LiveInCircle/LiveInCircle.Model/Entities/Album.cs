using LiveInCircle.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.Model.Entities
{
  public  class Album:BaseEntity
    {
        public Album()
        {
            Continued = true;
            Discounted = false;
            IsActive = true;
        }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public string AlbumArtUrl { get; set; }
        public bool Continued { get; set; }
        public bool Discounted { get; set; }
        public int ArtistID { get; set; }
        public int GenreID { get; set; }
        public Artist Artist { get; set; }
        public Genre Gengre { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
