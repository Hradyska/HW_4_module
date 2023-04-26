namespace ConsoleDBModule.Models
{
    public class SongArtist
    {
        public virtual Song Songs { get; set; }
        public virtual Artist Artists { get; set; }
        public int SongId { get; set; }
        public virtual int ArtistId { get; set; }
    }
}
