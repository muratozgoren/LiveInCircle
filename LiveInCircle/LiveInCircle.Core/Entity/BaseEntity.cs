using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.Core.Entity
{
  public abstract  class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
