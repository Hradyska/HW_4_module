using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ConsoleDBModule.Models;

namespace ConsoleDBModule.Configurations
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder
                .ToTable("Song")
                .HasKey(p => p.Id);
            builder
                .Property(p => p.Id)
                .HasColumnName("SongId")
                .ValueGeneratedNever();
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.GenreId)
                .IsRequired(false)
                .HasMaxLength(100);
            builder
                .Property(p => p.ReleasedDate)
                .IsRequired();
            builder
                .Property(p => p.Duration)
                .IsRequired();

            builder
              .HasData(new[]
              {
                    new
                    {
                        Id = 1,
                        Title = "Dream on",
                        ReleasedDate = DateTime.Parse("27.06.1973").Date,
                        GenreId = 1,
                        Duration = TimeSpan.Parse("4:28")
                    },
                    new
                    {
                        Id = 2,
                        Title = "Feeling Good",
                        ReleasedDate = DateTime.Parse("01.01.1964"),
                        GenreId = 3,
                        Duration = TimeSpan.Parse("2:53")
                    },
                    new
                    {
                        Id = 3,
                        Title = "Whataya Want from Me",
                        ReleasedDate = DateTime.Parse("10.11.2009"),
                        GenreId = 2,
                        Duration = TimeSpan.Parse("3:47")
                    },
                    new
                    {
                        Id = 4,
                        Title = "Crazy",
                        ReleasedDate = DateTime.Parse("03.05.1994"),
                        GenreId = 1,
                        Duration = TimeSpan.Parse("5:16")
                    },
                    new
                    {
                        Id = 5,
                        Title = "Supermassive Black Hole",
                        ReleasedDate = DateTime.Parse("19.06.2006"),
                        GenreId = 4,
                        Duration = TimeSpan.Parse("3:29")
                    },
              });
        }
    }
}