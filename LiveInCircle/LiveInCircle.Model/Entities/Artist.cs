using LiveInCircle.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.Model.Entities
{
   public class Artist:BaseEntity
    {
        public Artist()
        {
            IsActive = true;
        }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public ICollection<Album> Album { get; set; }

    }
}
