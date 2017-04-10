using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AConsoleApplication1
{
    internal class Instrument
    {
        public string Name { get; set; }

        public void Play()
        {
            Console.WriteLine($"Sound of {Name} intrument");
        }
    }
}
