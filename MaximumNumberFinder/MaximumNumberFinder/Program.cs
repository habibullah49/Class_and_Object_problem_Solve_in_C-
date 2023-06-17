//একটি ক্লাস তৈরি করুন যা তিনটি সংখ্যা গ্রহণ করে এবং ঐ তিনটি সংখ্যার মধ্যে সর্বোচ্চ সংখ্যাটি প্রিন্ট করে।

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberFinder
{
    class Program
    {
        public class MaxValue
        {
            public int num1;
            public int num2;
            public int num3;

            public void maxValueCheck()
            {
                int max = 0;

                if (num1 > num2 && num1 > num3)
                {
                     max = num1;
                }

                else if (num2 > num1 && num2 > num3)
                {
                     max = num2;
                }

                else
                {
                    max = num3;
                }
                Console.WriteLine("Max value is : {0}",max);
            }
        }
        static void Main(string[] args)
        {
            int[] number = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            int num1 = number[0];
            int num2 = number[1];
            int num3 = number[2];

            MaxValue value = new MaxValue();

            value.num1 = num1;
            value.num2 = num2;
            value.num3 = num3;

            value.maxValueCheck();

            Console.ReadKey();
        }
    }
}
