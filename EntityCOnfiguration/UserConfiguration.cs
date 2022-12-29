using DataPOC.Core;
using DataPOC.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataPOC.EntityCOnfiguration
{
    public class UserConfiguration
    {
        public override void Config(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");

            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("user_id");

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("user_first_name");

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("user_last_name");

            builder.Property<string>(x => x.Email)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("user_email");

            builder.Property(x => x.Address)
                .IsRequired()
                .HasMaxLength(300)
                .HasColumnName("user_address");

            builder.Property(x => x.DateOfBirth)
                .IsRequired()
                .HasColumnName("user_date_of_birth");

            builder.Property(x => x.Phone)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnName("user_phone");
        }
    }
}
