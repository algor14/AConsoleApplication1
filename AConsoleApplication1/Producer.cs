using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AConsoleApplication1
{
    internal class Producer : Human
    {
        public bool IsCheating { get; set;}
        public override void DoWork()
        {
            if(IsCheating)
            {
                Console.WriteLine("Stole some money");
            }
            else
            {
                Console.WriteLine("Make more popular");
            }
        }
        public Producer(string name, DateTime birthdate)
            : base(name, birthdate)
        {

        }
    }
}
