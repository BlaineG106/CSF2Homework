using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Artist
    {
        //properties
        public Song[] Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //CTOR
        public Artist(Song[] tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }

        public Artist()
        {

        }

        //Methods
        public override string ToString()
        {
            string songsNeeded = "";
            foreach (Song s in Tracks)
            {
                songsNeeded += s + "\n";
            }
            return string.Format("Tracks: {0}\n" +
                "Title: {1}\n" +
                "Genre: {2}\n",
                songsNeeded, Title, Genre);
        }

    }
}
