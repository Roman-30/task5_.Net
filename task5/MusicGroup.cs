using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal abstract class MusicGroup : Group
    {
        public string Name { get; set; }
        public int NumOfMembers { get; set; }
        public string Genre { get; set; }

        public string PlayMusic()
        {
            return "Playing music";
        }

        public string StopMusic()
        {
            return "Stopping music";
        }

        public abstract string Practice();
    }
}
