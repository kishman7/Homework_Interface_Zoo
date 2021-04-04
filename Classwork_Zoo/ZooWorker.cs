using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork_Zoo
{
    class ZooWorker : IWatch
    {
        public Animals Animal { get; set; }
        public string Name { get; set; }
        public ZooWorker(string name, Animals animal)
        {
            Name = name;
            Animal = animal;
        }
        public override string ToString() => $"Name zooworker is {Name}";
        public void Watch()
        {
            Console.WriteLine($"Zooworker {Name} watch on the {Animal}");
        }
        public void Feed()
        {
            Console.WriteLine($"Zooworker {Name} feed to {Animal}");
        }
    }
}
