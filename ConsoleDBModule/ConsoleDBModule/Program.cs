using ConsoleDBModule.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleDBModule
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ConsoleDataBaseContextFactory consoleDataBaseContextFactory = new ConsoleDataBaseContextFactory();
            var context = consoleDataBaseContextFactory.CreateDbContext(args);
            using (context)
            {
                var songArtists = context.SongArtists.AsNoTracking();
                var songs = context.Songs.AsNoTracking();
                var artist = context.Artists.AsNoTracking();
                var genre = context.Genres;
                Console.WriteLine($"{Environment.NewLine}Title of Songs, Name of Artists, Genre Title. Genre != null, Artist is alive{Environment.NewLine}****************");

                // Title of Songs, Name of Artists, Genre Title. Genre != null, Artist is alive
                var temp1 = songs
                    .Where(s => s.GenreId != null)
                    .Join(songArtists, s => s.Id, sa => sa.SongId, (s, sa) => new
                    {
                        Title = s.Title,
                        GenreId = s.GenreId,
                        ArtistId = sa.ArtistId
                    })
                    .Join(artist.Where(a => a.DateOfDeath == null), sa => sa.ArtistId, a => a.Id, (sa, a) => new
                    {
                        Title = sa.Title,
                        ArtistName = a.Name,
                        GenreId = sa.GenreId
                    })
                    .Join(genre, sa => sa.GenreId, g => g.Id, (sa, g) => new
                    {
                        Title = sa.Title,
                        ArtistName = sa.ArtistName,
                        GenreTitle = g.Title
                    });
                foreach (var song in temp1)
                {
                    Console.WriteLine($"{song.Title} {song.ArtistName} {song.GenreTitle}");
                }

                Console.WriteLine($"{Environment.NewLine}Count of songs in every Genre{Environment.NewLine}*************************");

                // Count of songs in every Genre
                var temp2 = songs.Where(s => s.GenreId != null)
                    .GroupBy(x => x.GenreId)
                    .Select(g => new { GenreId = g.Key, Count = g.Count() })
                    .Join(genre, s => s.GenreId, g => g.Id, (s, g) => new
                    {
                        Count = s.Count,
                        Title = g.Title,
                    });
                foreach (var song in temp2)
                {
                    Console.WriteLine($"{song.Title} {song.Count}");
                }

                Console.WriteLine($"{Environment.NewLine}Songs whith ReleasedDate < Artist DateOfBirth***********************{Environment.NewLine}");

                // Songs whith ReleasedDate < Artist DateOfBirth
                var temp3 = songs.Join(songArtists, s => s.Id, sa => sa.SongId, (s, sa) => new
                {
                    Title = s.Title,
                    Release = s.ReleasedDate,
                    ArtistId = sa.ArtistId
                })
                .Join(artist, x => x.ArtistId, a => a.Id, (x, a) => new
                {
                    Title = x.Title,
                    Release = x.Release,
                    ArtistName = a.Name,
                    ArtistBD = a.DateOfBirth
                })
                .GroupBy(z => z.Title)
                .Select(y => y.OrderByDescending(y => y.ArtistBD).First()).ToList()
                .Where(x => x.Release < x.ArtistBD).ToList();
                foreach (var song in temp3)
                {
                    Console.WriteLine($"{song.Title} {song.Release} {song.ArtistName} {song.ArtistBD}");
                }
            }
        }
    }
}
