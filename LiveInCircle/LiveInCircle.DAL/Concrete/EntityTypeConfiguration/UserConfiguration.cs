using LiveInCircle.Model.Entities;
using LiveInCircle.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveInCircle.DAL.Concrete.EntityTypeConfiguration
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityAlwaysColumn();
            builder.Property(a => a.Email).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Password).HasMaxLength(20).IsRequired();
            builder.Property(a => a.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.PhoneNumber).HasMaxLength(18);
            builder.Property(a => a.Address).HasMaxLength(200).IsRequired();
            builder.HasIndex(a => a.Email).IsUnique();

            builder.HasData(new User
            {
                ID = 1,
                FirstName = "Murat",
                LastName = "Özgören",
                Email = "muratozgoren@icloud.com",
                Password = "123",
                Address = "İstanbul",
                Role = UserRole.Admin,
                IsActive = true
            });
        }
    }
}
