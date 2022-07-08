using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_HW
{
    public class MethodPractice
    {
        public int[] GenerateNumbers() { 
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++) { 
                numbers[i] = i+1;
            }
            return numbers;
        }
        public int[] GenerateNumbers(int len)
        {
            int[] numbers = new int[len];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i+1;
            }
            return numbers;
        } 
        public void Reverse(int[] nums) {
            int start = 0;
            int end = nums.Length - 1;
            while (start < end) { 
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        public void PrintNumbers(int[] nums) {
            Console.WriteLine(String.Join(",", nums));
        }

        public int Fibonacci(int n) { 
            if(n<=1)
              return n;
            int res = Fibonacci(n - 1) + Fibonacci(n - 2);
            return res;
        }
    }
}
