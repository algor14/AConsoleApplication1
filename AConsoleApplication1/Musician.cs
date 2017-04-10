using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AConsoleApplication1
{
    public class Musician:Human
    {
        public Instrument[] Instruments { get; set; }

        public Musician(string name, DateTime birthdate)
            : base(name, birthdate)
        {
            
        }
        public override void DoWork()
        {
            foreach (var item in Instruments)
            {
                item.Play();
            }
        }
    }
}
