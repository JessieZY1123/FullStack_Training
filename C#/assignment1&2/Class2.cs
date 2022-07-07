using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class Class2
    {
        //Practice Arrays

        public void TodoList()
        {
            Console.WriteLine("Enter command (+ item, - intem, or -- to clear item)");
            String input = Console.ReadLine();
            List<String> list = new List<String>();
            while (input != null)
            {
                if (input[0] == '+')
                {
                    list.Add(input);
                    Console.WriteLine("Item added.");

                }
                else if (input[0] == '-' && input[1] != '-')
                {
                    list.Remove(input);
                    Console.WriteLine("Item removed");

                }
                else if (input[0] == '-' && input[1] == '-')
                {
                    list.Clear();
                    Console.WriteLine("Clear Item");

                }
                else
                {
                    Console.WriteLine("Please Enter the Corrent Character");

                }
                Console.WriteLine("Enter command (+ item, - intem, or -- to clear item)");
                input = Console.ReadLine();
            }

        }
        // 03 find prime
        public int[] FindPrimersInRange(int startNum, int endNum)
        {
            List<int> primers = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (i == 1) { continue; }
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(endNum); j++)
                {
                    if ((i != j) && (i % j == 0))
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    primers.Add(i);
                }
            }
            int[] res = primers.ToArray();
            return res;
        }

        //04 rotate
        public int[] RotateArray(int[] arr, int k)
        {
            int n = arr.Length;
            int[] array = new int[n];
            for (int i = 1; i <= k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[(i + j) % n] += arr[j];

                }
            }
           return array;
        }

        //05
        public int[] GetEqualSeq(int[] nums) { 
            int start=0;
            int count = 1;
            int index = 0;
            int res = 0;
           for(int i = 1; i< nums.Length;i++) {
                if (nums[i]!= nums[start])
                {
                    start= i;
                    count = 1;
                }
                else { 
                   count++;
                    if (res < count) {
                        res = count;
                        index = start;
                    }
                }
            }
            int[] result = new int[res];
            for (int i = 0; i < res; i++) {
                result[i] = nums[index];
            }
            return result;
        }

        //06
        public void MostFrequentNum(int[] nums)
        {   int MaxCount= 0;
            int result = 0;
            int count = 0;
            //List<int> list = new List<int>();
            for (int i =0; i<nums.Length;i++)
            {
                count = 0;
                for (int j = 0; j < nums.Length; j++) {
                    if (i == nums[j] && i!=j) { 
                        count++;
                    }
                    if (MaxCount < count)
                    {
                        MaxCount = count;
                        result = nums[j];
                    }
                    
                }
            }
            
            Console.WriteLine($"The number {result} is the most frequent (occurs {MaxCount} times)");
        }

        //Practice Strings:
        //01 Reverse string
        public String Reverse(String str ) {
            int left = 0;
            int right = str.Length-1;
            if (str.Length == 1) {
                return str;
            }
            Char[] chars = str.ToCharArray();
            
            while (left < right) { 
                char temp = chars[left];
               chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }
            String res = new string(chars);
            return res;
        }

        //02: Reverse Sentence

        public String ReverseSentence(String str) {
        
            int index = 0;          
            char ch = ' ';
            Char[] separators = new char[] {'.', ',', ':', ';', '=', '(', ')', '&',
               '[', ']', '"', '\'','\\', '/', '?','!',' '};
            String[] array = str.Split(" ");
            String[] arrayWithoutPun = str.Split(separators);
            List<string> list = new List<string>();
            for(int i = arrayWithoutPun.Length -1; i>=0;i--) {
                if (arrayWithoutPun[i] != " ") {
                    list.Add(arrayWithoutPun[i].Trim());
                }
            }
            Console.WriteLine(String.Join(" ", list));
            for (int j =0; j<array.Length;j++)
            {
                foreach (char c in array[j])
                {
                    if (separators.Contains(c)) {
                        //Console.WriteLine(j);
                        //Console.WriteLine(list[j]);
                        //Console.WriteLine(String.Join(" ", arrayWithoutPun[j].ToCharArray().Append(c)));
                    }
                    
                }                   

            }
            return String.Join(" ", arrayWithoutPun);
        }
     
     

        //03 palindromes

        public String[] Palindromes(String str) {
            String[] array = str.Split(" ");
            Char[] separators = new char[] {'.', ',', ':', ';', '=', '(', ')', '&',
               '[', ']', '"', '\'','\\', '/', '?', ' ','!'};
            List<String> res = new List<string>();
            foreach (String s in array) {
                String ss = new String(s.Trim(separators));
                if (IsPalindromes(ss)) {
                    res.Add(ss);
                }
            }
            return res.ToArray();
        }

        public bool IsPalindromes(String str)
        {
            char[] chars = str.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;
            while (left < right)
            {
                if(chars[left] != chars[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        //04:URL
        public void ParseURL(String str) {
            //https:// www.apple.com /iphone
            String protocol = new String(""),
                   server = new String(""),
                   resource = new String("");

            if (str.Contains(":"))
            {
                protocol = new String(str.Split(':')[0]);
                str= str.Replace(protocol + "://", "");
            }

            if (str.Contains('/'))
            {
                 server = new String(str.Split('/')[0]);
              resource = str.Replace(server + "/", "");
            }
            Console.WriteLine($"{str}\n [protocol] = \"{protocol}\" \n [server] = \"{server}\" \n [resource] = \"{resource}\"");

        }
    }
}
