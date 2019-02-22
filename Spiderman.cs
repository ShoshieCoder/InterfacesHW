using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Spiderman: Human, IClimb
    {
        public Spiderman(string name, int age, double webLeft) : base(name, age)
        {
            this.WebLeft = webLeft;
        }

        public double WebLeft { get; private set; }

        public override string Name { get; set; }

        public void ActivateSuperPowers()
        {
            Climb();
        }

        public void Climb()
        {
            Console.WriteLine($"Spiderman {this.Name} is wallclimbing");
        }

        public override string ToString()
        {
            return $"Spiderman {WebLeft}" + base.ToString();
        }
    }
}
