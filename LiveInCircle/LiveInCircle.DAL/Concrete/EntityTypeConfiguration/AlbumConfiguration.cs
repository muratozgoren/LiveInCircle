using LiveInCircle.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.DAL.Concrete.EntityTypeConfiguration
{
    class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("Album");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityAlwaysColumn();
            builder.Property(a => a.Title).HasMaxLength(100).IsRequired();
            builder.Property(a => a.AlbumArtUrl).HasMaxLength(256);
            builder.Property(a => a.Price).HasPrecision(3, 2);

        }
    }
}
