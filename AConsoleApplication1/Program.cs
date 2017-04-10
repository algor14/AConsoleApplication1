using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Band rollingStones = new Band("The Rolling Stones", Ganre.Rock)
            {
                //Name = "The Rolling Stones",
                //Ganre = Ganre.Rock,
                Musicians = new Musician[]
                {
                    new Musician("Mick Jagger", DateTime.Now) {Instruments = new Instrument[] { new Instrument() {Name = "Drum" } }},
                    new Musician( "Kith Richards", DateTime.Now) {Instruments = new Instrument[] { new Instrument() {Name = "guitar" } } }
                },
                TechPerconnel = new TechSpecialist[]
                {
                    new TechSpecialist("Jhon Smith", DateTime.Now) {},
                    new TechSpecialist("Jhon Smith", DateTime.Now) {},
                    new TechSpecialist("Jhon Smith", DateTime.Now) {}
                },
                Producers = new Producer[]
                {
                    new Producer("Joe Black", DateTime.Now) {IsCheating = false}
                }
            };
            rollingStones.PerformConcert();
            Bar bar = new Bar("Old Ham");
            //bar.MakeDrunk(rollingStones.GetAllPeople);
        }
    }
}
