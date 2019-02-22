using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Superman: Human, IFly
    {
        public Superman(string name, int age, long speed) : base(name, age)
        {
            this.Speed = speed;
        }

        public override string Name
        {
            get;
            set;
        }

        public void ActivateSuperPowers()
        {
            Fly();
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is FLYING?!");
        }

        public long Speed { get; private set; }


        public override string ToString()
        {
            return $"SuperMan {Speed} " + base.ToString();
        }
    }

    }
}
