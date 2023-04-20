namespace ConsoleDBModule.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public virtual string InstagramUrl { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public virtual List<SongArtist> SongArtists { get; set; }
        public virtual List<Song> Songs { get; set; } = new List<Song>();
    }
}
