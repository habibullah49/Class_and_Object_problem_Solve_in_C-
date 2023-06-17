// একটি ক্লাস তৈরি করুন যা সংখ্যা গ্রহণ করে এবং ঐ সংখ্যার বর্গমূল প্রিন্ট করে।

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootCalculator
{
    class Program
    {
        public class SqureCalculator
        {
            public int number;

            public void squreRoot()
            {
                Console.WriteLine("Squre : {0}", number* number);
            }
        }

      
        static void Main(string[] args)
        {
            

            Console.Write("Enter Your Number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            SqureCalculator value = new SqureCalculator();
            value.number = n;

            value.squreRoot();

            Console.ReadKey();
        }
    }
}
