using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ConsoleDBModule.Models;

namespace ConsoleDBModule.Configurations
{
    internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder
                .ToTable("Genre")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("GenreId")
                .ValueGeneratedNever();
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(50);

            builder
              .HasData(new[]
              {
                    new
                    {
                        Id = 1,
                        Title = "Rock"
                    },
                    new
                    {
                        Id = 2,
                        Title = "Pop-Rock"
                    },
                    new
                    {
                        Id = 3,
                        Title = "Jazz"
                    },
                    new
                    {
                        Id = 4,
                        Title = "Funk-Rock"
                    }
              });
        }
    }
}