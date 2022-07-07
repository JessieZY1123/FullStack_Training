// See https://aka.ms/new-console-template for more information
using _02UnderstandingTypes;

Class1 c = new Class1();
Class2 c2 = new Class2();
////Assignment 01:
//// 01:
//c.NumCheck();

//////02:
//Console.WriteLine("Please input a number:");
//int input = Convert.ToInt32(Console.ReadLine());
//c.centuries(input);

//c.FizzBuzz(100);
//c.Guess();
//c.Print_a_Pyramid();
//c.birth_date();
//c.Count();

//// --- Assignment 2 -- Practice Arrays 01
//int[] arr1 = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    arr1[i] = i;

//}
//int[] arr2 = new int[10];
//arr2 = arr1;
//Console.WriteLine(String.Join(",", arr1));
//Console.WriteLine(String.Join(",", arr2));

//// 02
//c2.TodoList();

////03
//Console.WriteLine(String.Join(",", c2.FindPrimersInRange(0, 8)));

////04
//int[] arr = { 3, 2, 4, -1 };
//Console.WriteLine(String.Join(" ", c2.RotateArray(arr, 2)));

////05
//int[] array1 = { 2, 1, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1 };
//int[] array2 = { 4, 4, 4, 4 };
//Console.WriteLine(String.Join(" ", c2.GetEqualSeq(array1)));
//Console.WriteLine(String.Join(" ", c2.GetEqualSeq(array2)));

////06
//int[] array3 = { 2, 1, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1 };
//int[] array4 = { 7, 7, 7, 0, 2, 2, 2, 0, 10, 10, 10 };
//c2.MostFrequentNum(array3);
//c2.MostFrequentNum(array4);

//////Practice Strings:
//////01 Reverse String
//String str = Console.ReadLine();
//Console.WriteLine(c2.Reverse(str));

////02:Reverse Sentence
String str2 = "C# is not C++, and PHP is not Delphi!";
Console.WriteLine(c2.ReverseSentence(str2));

//////03:Palindromes
//String str3 = " Hi, exe? ABBA! Hog fully a string: ExE. Bob";
//Console.WriteLine(String.Join(" ", c2.Palindromes(str3)));

////04 URL
//String str4 = "https://www.apple.com/iphone";
//c2.ParseURL(str4);