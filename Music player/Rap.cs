using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_player
{
    public class Rap: Music
    {
        public Rap(string title, string artist, string album):base(title, artist, album)
        {
            
        }
        public override string Play()
        {
            return $"{base.Play()}";
        }
    }
}

