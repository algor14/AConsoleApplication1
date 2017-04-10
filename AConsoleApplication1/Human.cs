using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AConsoleApplication1
{
    public abstract class Human
    {
        public DateTime Birthdate { get; }
        public string Name { get; }

        public abstract void DoWork();
        public Human(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}
