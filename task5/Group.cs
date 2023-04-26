using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal interface Group
    {
        string Name { get; set; }
        string PlayMusic();
        string StopMusic();
    }
}
