using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    //string functions
    
    /*internal class String
    {
        private static void Main()
        {
            Console.WriteLine("enter the string : ");
            string s = Console.ReadLine();

            int length = s.Length;
            Console.WriteLine("Length of the string is : " + length);

            Console.WriteLine("Upper case string is : " + s.ToUpper());
            Console.WriteLine("Lower case string is : " + s.ToLower());

            bool contains = s.Contains("this");
            Console.WriteLine("String contains \"this\" :" + contains);

            bool startsWithHello = s.StartsWith("Hello");
            Console.WriteLine("String starts with \"Hello\" : " + startsWithHello);

            bool endsWithHello = s.EndsWith("World");
            Console.WriteLine("String ends with \"World\" : " + endsWithHello);

            string replaced = s.Replace("World", "All");
            Console.WriteLine("Replaced string is : " + replaced);

            string substring = s.Substring(2, 10);
            Console.WriteLine("Substring is : " + substring);

            Console.WriteLine("enter the string to check index : ");
            string str = Console.ReadLine();

            int index = s.IndexOf(str);
            Console.WriteLine("Index is : " + index);

            Console.WriteLine("Enter the string to be separated : ");
            string str1 = Console.ReadLine();

            string[] words = str1.Split(',');

            Console.WriteLine("Splitting based on ',' is ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    } */


    //string reverse
    internal class String2
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int num = n, reverse = 0, sum = 0, rem = 0;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                reverse = reverse * 10 + (rem);
                num = num / 10;
            }
            Console.WriteLine("the reverse of the given number is " + reverse);
            Console.WriteLine("the sum of the given number is " + sum);
        }
    }
}

