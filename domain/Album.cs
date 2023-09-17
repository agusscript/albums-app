using System;

namespace domain
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int AmountTracks { get; set; }
        public string ReleasedDate { get; set; }
        public string CoverImage { get; set; }
        public Genre Genre { get; set; }
    }
}
