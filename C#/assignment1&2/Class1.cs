using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _02UnderstandingTypes
{
    public class Class1
    {   //Practice number sizes and ranges
        //sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
        public void NumCheck() {
            Console.WriteLine($"The Max value of Sbyte type is { SByte.MaxValue}, the min value is {SByte.MinValue}");
            Console.WriteLine($"The Max value of byte type is {Byte.MinValue}, the min value is {Byte.MinValue}");
            Console.WriteLine($"The Max value of Short type is {Int16.MaxValue}, the min value is {Int16.MinValue}");
            Console.WriteLine($"The Max value of ushort  type is {UInt16.MaxValue}, the min value is {UInt16.MinValue}");
            Console.WriteLine($"The Max value of int  type is {Int32.MaxValue}, the min value is {Int32.MinValue}");
            Console.WriteLine($"The Max value of uint  type is {UInt32.MaxValue}, the min value is {UInt32.MinValue}");
            Console.WriteLine($"The Max value of long  type is {Int64.MaxValue}, the min value is {Int64.MinValue}");
            Console.WriteLine($"The Max value of ulong type is {UInt64.MaxValue}, the min value is {UInt64.MinValue}");
            Console.WriteLine($"The Max value of float  type is {float.MaxValue}, the min value is {float.MinValue}");
            Console.WriteLine($"The Max value of double  type is {Double.MaxValue}, the min value is {Double.MinValue}");
            Console.WriteLine($"The Max value of decimal type is {decimal.MaxValue}, the min value is {decimal.MinValue}");
       
        }
        //02
        public void centuries(int input) {
            int years = input * 100;
            double days = years * 365.24;
            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            decimal milliseconds = (decimal)(seconds * 1000);
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine($"{input} centuries = {years} years = " +
                $"{days} days = {hours} hours = {minutes} minutes = {seconds} seconds" +
                $" = {milliseconds} milliseconds = {microseconds} microseconds = " +
                $"{nanoseconds} nanoseconds");
        }

        //Practice loops and operators:
        //01
        public void FizzBuzz(int input) {
            for (int i = 1; i <= input; i++) {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(" FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(" Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(" Buzz ");
                }
                else {
                    Console.WriteLine(i+" ");
                }
            
            }
        
        }
        //02
        public void Print_a_Pyramid()
        {
            for (int i = 10; i >= 0; i -= 2)
            {
                for (int k = 0; k <= i; k += 2)
                {
                    Console.Write(" ");
                }
                for (int j = 10; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //03
        public void Guess() {
            int correntNumber = new Random().Next(3) + 1;  // 1-3
            

            while (true) {
                Console.WriteLine("Please enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == correntNumber)
                {
                    Console.WriteLine("Corrent!!");
                    return;
                }
                else if (input > correntNumber)
                {
                    if (input > 3) {
                        Console.WriteLine("Please enter number less than 3.");
                    }
                    Console.WriteLine("Your number is greater than corrent number");
                }
                else {
                    if (input < 1)
                    {
                        Console.WriteLine("Please enter number greater than 1.");
                    }
                    Console.WriteLine("Your number is less than corrent number");
                }
            }
        }

       
        //04
        public void birth_date() {
            Console.WriteLine("Please enter your birthday(MM/DD/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            int days = (DateTime.Today - date).Days;
            Console.WriteLine($"The date of birth is now {days} days old.");
            DateTime anniversaryDate = date.AddDays(10000 - (days % 10000));
            Console.WriteLine($"AnniversaryDate is {anniversaryDate}");

        }
        //05
        public void Greeting() {
            String timeNow = DateTime.Now.ToString("t", CultureInfo.CreateSpecificCulture("es-ES"));
            DateTime current = DateTime.Now;
            byte hour = byte.Parse(current.Hour.ToString());
            if ((hour > 23) && (hour <= 4)) 
                Console.WriteLine("Good night");
            if ((hour > 4) && (hour <= 11)) 
                Console.WriteLine("Good morning");
            if ((hour > 11) && (hour <= 19)) 
                Console.WriteLine("Good afternoon");
            if ((hour > 19) && (hour <= 23)) 
                Console.WriteLine("Good evening");
        }
        //06
        public void Count() {
            for (int i = 1; i <= 4; i++) {
                for (int j = 0; j <= 24; j+=i) {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            
            }
        
        }

    }
}
