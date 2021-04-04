using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork_Zoo
{
    class Bear : Animals
    {
        public Bear(string animal) : base (animal) { }
        public override string ToString() => $"bear";
        
    }
    class Parrot : Animals
    {
        public Parrot(string animal) : base(animal) { }
        public override string ToString() => $"parrot";

    }
    class Wolf : Animals
    {
        public Wolf(string animal) : base(animal) { }
        public override string ToString() => $"wolf";

    }
}
