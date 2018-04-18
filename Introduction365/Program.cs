using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction365
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Completed
            //Given an integer num, repeatedly add all its digits until the result has only one digit.
            //For example:
            //Given num = 38, the process is like: 3 + 8 = 11, 1 + 1 = 2.Since 2 has only one digit, return it.

            int sampleNumber = 5874;
            //int sampleNumber = 38;

            Console.WriteLine(addDigits(sampleNumber));

            int addDigits(int number)
            {
                while(number > 10)
                {
                    int rightNum = number % 10;
                    int leftNum = number / 10;
                    number = leftNum + rightNum;
                }
                return number;
            }
            */

            /*
            //Completed
            //String Compression: Implement a method to perform basic string compression using the counts of repeated characters. For example, the string "aabcccccaaa" would become "a2b1c5a3". If the "compressed" string would not become smaller than the original string, your method should return the original string. You can assume the string has only uppercase and lowercase letters (a-z, A-Z).

            //string sampleString = "aabcccccaaa";
            //string sampleString = "Abc";
            string sampleString = "AaaBbCccccccccccccc";

            Console.WriteLine(stringCompression(sampleString));

            string stringCompression(string str)
            {
                StringBuilder sb = new StringBuilder();
                int currentCount = 1;
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str[i] == str[i + 1])
                    {
                        currentCount++;
                    }
                    else if (str[i] != str[i + 1])
                    {
                        sb.Append(str[i]).Append(currentCount);
                        currentCount = 1;
                    }
                }
                sb.Append(str[str.Length - 1]).Append(currentCount);
                if (str.Length < sb.Length)
                {
                    return str;
                }
                else
                {
                    return sb.ToString();
                }
            }
            */


            /*
            //Completed
            //Write a function to zero all duplicate values in an integer array
            int[] numbers = new int[] { 2, 6, 8, 3, 4, 2, 6, 4, 1, 5 };

            int[] zeroDuplicateValue(int [] a)
            {
                List<int> numbersFound = new List<int>();
                foreach(int i in a)
                {
                    if(!numbersFound.Contains(i))
                    {
                        numbersFound.Add(i);
                    }
                    else
                    {
                        numbersFound.Add(0);
                    }
                }
                return numbersFound.ToArray();
            }

            int [] zeroDups = zeroDuplicateValue(numbers);

            foreach(int i in zeroDups)
            {
                Console.Write(i + " ");
            }
            */
        }
    }
}
