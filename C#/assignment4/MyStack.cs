using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_HW
{
    public class MyStack<T>
    {   private int Index { get; set; }
        private List<T> listElement { get; set; }

        public MyStack() {
            Index = -1;
            listElement = new List<T>();
        }
        public int count() {
            return Index+1;
        }

        public void Push(T element) {
            listElement.Add(element);
            Index++;
        }

        public T Pop() {
            if (Index == -1) {
                Console.WriteLine("Empty Stack");
            } 
            return listElement[Index--];
        }
    }
}
