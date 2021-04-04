using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork_Zoo
{
    abstract class Animals : IWalk, IEat, ISleep
    {
        public string Animal { get; set; }
        public Animals(string animal)
        {
            Animal = animal;
        }
        public void Walk()
        {
            Console.WriteLine($"{Animal} wolking.");
        }
        public void Eat()
        {
            Console.WriteLine($"{Animal} eating.");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Animal} sleeping.");
        }
    }
}
