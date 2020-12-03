using LiveInCircle.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.DAL.Concrete.EntityTypeConfiguration
{
    class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");            
            builder.HasKey(a => new { a.AlbumID, a.OrderID });
            builder.Property(a => a.Price).HasPrecision(3, 2);
            
        }
    }
}
