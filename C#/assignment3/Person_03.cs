using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_HW
{
    public class Person
    {
        private int _id;
        private string _name;
        public int Id 
        {
            get {
                return _id;
            }
            set { 
                _id = value;
            }
        
        }
        public string Name 
        { 
            get => _name;
            set { _name = value; }
        
        }

        

        public Person(){
            Id = 0;
        }
        public Person(int id, String name) { 
            Id = id;
            Name = name;
        }


    }

}
