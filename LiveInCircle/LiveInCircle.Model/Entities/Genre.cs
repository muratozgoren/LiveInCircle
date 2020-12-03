using LiveInCircle.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.Model.Entities
{
  public  class Genre : BaseEntity
    {
        public Genre()
        {
            IsActive = true;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
