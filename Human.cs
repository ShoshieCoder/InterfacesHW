using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Human
    {
        private int _age;

        abstract public string Name
        {
          get;
          set;
        }

        public int Age { get; }

        public Human(string name, int age)
        {
            this.Name = name;
            this._age = age;
        }
    }
}
