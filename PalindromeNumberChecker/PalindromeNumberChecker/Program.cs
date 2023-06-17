// একটি ক্লাস তৈরি করুন যা সংখ্যা গ্রহণ করে এবং ঐ সংখ্যার স্বাপ্নিল সংখ্যা হলে "স্বাপ্নিল সংখ্যা" প্রিন্ট করে, 
//অন্যথায় "স্বাপ্নিল সংখ্যা নয়" প্রিন্ট করে। একটি স্বাপ্নিল সংখ্যা হলে সেটির সংখ্যাটি উল্টাপাল্টা করলে একই সংখ্যা পাওয়া যায়।

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumberChecker
{
    class Program
    {
        public class checkPalindorme
        {
            public int number;

            public void PalindormeNumber()
            {
                int orginalNumber = number;

                int reverseNumber = 0;

                while(number != 0)
                {
                    int remainder = number % 10;

                    reverseNumber = (reverseNumber * 10) + remainder;

                    number /=  10;
                }

                if (orginalNumber == reverseNumber)
                {
                    Console.WriteLine("Number is Palidorme");
                }
                else
                {
                    Console.WriteLine("Number is not Palindrome");
                }
            }


        }
        static void Main(string[] args)
        {
            Console.Write("Enter Your Number : ");

            int n = Convert.ToInt32(Console.ReadLine());

            checkPalindorme value = new checkPalindorme();

            value.number = n;

            value.PalindormeNumber();

            Console.ReadKey();
        }
    }
}
