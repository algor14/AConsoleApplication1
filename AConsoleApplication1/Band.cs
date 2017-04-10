using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AConsoleApplication1
{
    internal class Band
    {
        public string Name { get;}
        public Ganre Ganre { get;}

        public Musician[] Musicians { get; set; }
        public Human[] TechPerconnel { get; set; }
        public Producer[] Producers { get; set; }

        public Band(string name, Ganre ganre)
        {
            Name = name;
            Ganre = ganre; 
        }

        internal void PerformConcert()
        {
            foreach (var item in TechPerconnel)
            {
                item.DoWork();
            }
            foreach (var item in Musicians)
            {
                item.DoWork();
            }
            foreach (var item in Producers)
            {
                item.DoWork();
            }
        }
    }
}
