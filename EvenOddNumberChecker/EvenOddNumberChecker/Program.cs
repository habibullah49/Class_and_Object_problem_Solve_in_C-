// একটি ক্লাস তৈরি করুন যা একটি সংখ্যা গ্রহণ করে এবং তার পরে 
//ঐ সংখ্যাটির জোড় বা বিজোড় হলে সেটি "জোড় সংখ্যা" বা "বিজোড় সংখ্যা" প্রিন্ট করে।

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddNumberChecker
{
    class Program
    {
        public class EvenOrOdd
        {
            public int number;

            public void EvenorOddChecker()
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Number is Even");
                }
                else
                {
                    Console.WriteLine("Number is odd");
                }
            }
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter Your Number : ");

            int number = Convert.ToInt32(Console.ReadLine());

            EvenOrOdd value = new EvenOrOdd();

            value.number = number;
            value.EvenorOddChecker();

            Console.ReadKey();
        }
    }
}
