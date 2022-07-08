using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day4_HW
{
    public class MyList<T>
    { 
        private int Size { get; set; }
        public T[] Items;
        public MyList() {
            Size = 0;
            Items = new T[0];
        }
        public void Add(T element)
        {
            T[] values = new T[Items.Length+1];
            for (int i = 0; i < Items.Length; i++) { 
                values[i] = Items[i];
            }
            Items[Items.Length+1] = element;
            Size++;
            Items = values;
        }
        public T Remove(int index) {
            if (Size == 0)
            {
                throw new NotImplementedException();
            } 


            T[] values = new T[Items.Length -1];
            T element = Items[index];
            for (int i = 0, k = 0; i < Items.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                values[k++] = Items[i];

             }
            Items = values;
            return element;
        }

        public bool Contains(T element) {
            for (int i = 0; i < Size; i++)
            {
                if (Items[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        public void Clear() {
            Items = new T[0];
        }
        public void InsertAt(T element, int index) {
            T[] values = new T[Items.Length + 1];
            for (int i = 0,k=0; i < Items.Length;i++)
            {
                if (i == index) { 
                    values[index] = element;
                }
                else
                {
                    values[i] = Items[k++];
                }
               
            }
            Size++;
            Items = values;
        }
        public void DeleteAt(int index) {

            Remove(index);
        }
        public T Find(int index) {

            return Items[index];

        }

    }
}
