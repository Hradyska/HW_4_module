using ConsoleDBModule.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleDBModule.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder
                .ToTable("Artist")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("ArtistId")
                .ValueGeneratedNever();
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.DateOfBirth)
                .IsRequired();
            builder
                .Property(p => p.DateOfDeath)
                .IsRequired(false);
            builder.Property(p => p.Phone)
                .IsRequired(false);
            builder.Property(p => p.EMail)
                .IsRequired(false);
            builder.Property(p => p.InstagramUrl)
                .IsRequired(false);

            builder
              .HasData(new[]
              {
                    new
                    {
                        Id = 1,
                        Name = "Aerosmith",
                        DateOfBirth = DateTime.Parse("01.10.1970").Date,
                        InstagramUrl = "https://www.instagram.com/aerosmith/"
                    },
                    new
                    {
                        Id = 2,
                        Name = "Andru Donalds",
                        DateOfBirth = DateTime.Parse("16.11.1974").Date,
                        InstagramUrl = "https://www.instagram.com/andrudonalds/"
                    },
                    new
                    {
                        Id = 3,
                        Name = "Muse",
                        DateOfBirth = DateTime.Parse("01.01.1994").Date,
                        InstagramUrl = "https://www.instagram.com/muse/"
                    },
                    new
                    {
                        Id = 4,
                        Name = "Adam Lambert",
                        DateOfBirth = DateTime.Parse("29.01.1982").Date,
                        InstagramUrl = "https://www.instagram.com/adamlambert/"
                    },
                    new
                    {
                        Id = 5,
                        Name = "Pink",
                        DateOfBirth = DateTime.Parse("08.09.1979 ").Date,
                        InstagramUrl = "https://www.instagram.com/Pink/"
                    },
              });
        }
    }
}
