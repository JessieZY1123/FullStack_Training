using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_HW
{
    public abstract class Animal_01{
        public string Name { get; set; }
        public string Description { get; set; }
        public abstract void Eat();
        public abstract void Sleep();
    }

    public class Dog : Animal_01
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating ");
        }
        public override void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }

    }
}
