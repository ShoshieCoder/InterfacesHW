using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Flash: Human, IFlash
    {
        public Flash(string name, int age, double voltage): base(name,age)
        {
            this.Voltage = voltage;
        }

        public override string Name
        {
            get;
            set;
        }

        public double Voltage { get; private set; }

        public void ActivateSuperPowers()
        {
            FireLightnings();
        }

        public void FireLightnings()
        {
            Console.WriteLine($"Flash {this.Name} is firing LIGHTNINGS?!");
        }

        public override string ToString()
        {
            return $"Flash {Voltage} " + base.ToString();
        }
    }
}
