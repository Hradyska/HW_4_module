using ConsoleDBModule.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleDBModule.Configurations
{
    internal class SongArtistConfigurationcs : IEntityTypeConfiguration<SongArtist>
    {
        public void Configure(EntityTypeBuilder<SongArtist> builder)
        {
            builder
                .HasKey(e => new { e.SongId, e.ArtistId });

            builder
              .HasData(new[]
              {
                    new
                    {
                        SongId = 1,
                        ArtistId = 1
                    },
                    new
                    {
                        SongId = 1,
                        ArtistId = 2
                    },
                    new
                    {
                        SongId = 2,
                        ArtistId = 3
                    },
                    new
                    {
                        SongId = 2,
                        ArtistId = 4
                    },
                    new
                    {
                        SongId = 3,
                        ArtistId = 4
                    },
                    new
                    {
                        SongId = 3,
                        ArtistId = 5
                    },
                    new
                    {
                        SongId = 4,
                        ArtistId = 1
                    },
                    new
                    {
                        SongId = 5,
                        ArtistId = 3
                    },
              });
        }
    }
}
