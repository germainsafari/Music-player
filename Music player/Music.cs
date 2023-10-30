using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_player
{
    public class Music

    {
        public string title;
        public string artist;
        public string album;
        public Music(string title, string artist, string album)
        {
            this.title = title;
            this.artist = artist;
            this.album = album;
            
        }
        public override string Play()
        {
            return $"{title} {artist} {album}";
        }
    }
}
