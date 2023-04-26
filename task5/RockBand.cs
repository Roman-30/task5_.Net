using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class RockBand : MusicGroup
    {
        public int NumOfGuitars { get; set; }
        public bool HasDrummer { get; set; }

        public string StageDive()
        {
            return "Jumping into the crowd!";
        }

        public override string Practice()
        {
            return "Rocking in the garage!";
        }
    }
}
