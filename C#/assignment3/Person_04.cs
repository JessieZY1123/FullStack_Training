using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_HW
{
    public class Person_04
    {
        public int Id { get;set; }
        public string Name { get; set; }

        public Person_04(){
            Id = 0;
        }
        public Person_04(int id, String name) { 
            Id = id;
            Name = name;
        }

        public virtual void getDescription() {
            Console.WriteLine($"{this.Name}'s description.");
        }

    }

    public class Student_04 : Person_04
    {


        public Student_04(int sId, string sName)
        {
            Id = sId;
            Name = sName;
        }

        public void enrollLec(string lecName) {
            Console.WriteLine($"{this.Name} enrolls {lecName}.");
        }
        public override void getDescription()
        {
            Console.WriteLine($"{this.Name} is a student.");
        }
    }

    public class Instructor_04 : Person_04
    {

        public string department { get; set; }
        public Instructor_04(int sId, string sName, string department)
        {
            Id = sId;
            Name = sName;
            this.department = department;
        }  
        public override void getDescription()
        {
            Console.WriteLine($"{Name} is a instructor, and the department is {this.department}");
        }


    }
}
