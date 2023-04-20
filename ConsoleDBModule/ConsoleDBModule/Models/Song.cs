namespace ConsoleDBModule.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleasedDate { get; set; }
        public TimeSpan Duration { get; set; }
        public virtual Genre Genre { get; set; }
        public int? GenreId { get; set; }
        public virtual List<SongArtist> SongArtists { get; set; }
        public virtual List<Artist> Artists { get; set; } = new List<Artist>();
    }
}
