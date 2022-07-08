using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_HW
{
    public abstract class Person_02
    {
        public int Id;
        public string Name;

        public Person_02(){
            Id = 0;
        }
        public Person_02(int id, String name) { 
            Id = id;
            Name = name;
        }

        public abstract void Activity();

    }

    public class Student_02 : Person_02
    {
        public override void Activity()
        {
            Console.WriteLine($"{Name} is having a class");
        }
    }

    public class Instructor_2 : Person_02
    {
        public override void Activity()
        {
            Console.WriteLine($"{Name} is teaching a class");
        }
    }
}
