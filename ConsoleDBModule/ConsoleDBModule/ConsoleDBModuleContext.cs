using ConsoleDBModule.Configurations;
using ConsoleDBModule.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ConsoleDBModule
{
    public class ConsoleDBModuleContext : DbContext
    {
        private readonly string _connectionString;
        public ConsoleDBModuleContext(DbContextOptions<ConsoleDBModuleContext> options)
            : base(options)
        {
        }

        public ConsoleDBModuleContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<SongArtist> SongArtists { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new SongArtistConfigurationcs());
            modelBuilder.Entity<Song>()
             .HasMany(e => e.Artists)
             .WithMany(e => e.Songs)
             .UsingEntity<SongArtist>(
             l => l.HasOne(p => p.Artists).WithMany(t => t.SongArtists).HasForeignKey(p => p.ArtistId).HasPrincipalKey(nameof(Artist.Id)),
             r => r.HasOne(p => p.Songs).WithMany(t => t.SongArtists).HasForeignKey(p => p.SongId).HasPrincipalKey(nameof(Song.Id)),
             j => j.HasKey(t => new { t.SongId, t.ArtistId }));
        }
    }
}
