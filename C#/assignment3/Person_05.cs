using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_HW
{
    public class Person_05
    {
        public int Id { get;set; }
        public string Name { get; set; }

        public Person_05(){
            Id = 0;
        }
        public Person_05(int id, String name) { 
            Id = id;
            Name = name;
        }

        public virtual void getDescription() {
            Console.WriteLine($"{this.Name}'s description.");
        }

        public virtual void SpecialWork() {
            Console.WriteLine("Im doing special work as a person");
        }
    }

    public class Student_05 : Person_05
    {

        public Student_05(int sId, string sName)
        {
            Id = sId;
            Name = sName;
        }
        public override void getDescription()
        {
            Console.WriteLine($"{this.Name} is a student.");
        }

        public override void SpecialWork() {
            Console.WriteLine("Take a class.");
        }
    }

    public class Instructor_05 : Person_05
    {

        public string department { get; set; }
        public Instructor_05(int sId, string sName, string department)
        {
            Id = sId;
            Name = sName;
            this.department = department;
        }

       
        public override void getDescription()
        {
            Console.WriteLine($"{Name} is a instructor, and the department is {this.department}");
        }
        public override void SpecialWork()
        {
            Console.WriteLine("Salary calculations.");
        }
    }
}
