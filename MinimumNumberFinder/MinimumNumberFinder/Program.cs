//একটি ক্লাস তৈরি করুন যা তিনটি সংখ্যা গ্রহণ করে এবং ঐ তিনটি সংখ্যার মধ্যে সর্বনিম্ন সংখ্যাটি প্রিন্ট করে।

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNumberFinder
{
    class Program
    {

        public class MinValue
        {
            public int num1;
            public int num2;
            public int num3;


            public void checkMinimumNumber()
            {
                int min = 0;

                if (num1 < num2 && num2 < num3)
                {
                    min = num1;
                }

                else if (num2 < num1 && num2 < num3)
                {
                    min = num2;
                }
                else
                {
                    min = num3;
                }

                Console.WriteLine("Minumum Value is : {0} ",min);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Your Number1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Number2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Number3 : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //Object Create

            MinValue value = new MinValue();

            value.num1 = num1;

            value.num2 = num2;

            value.num3 = num3;

            value.checkMinimumNumber();

            Console.ReadKey();

        }
    }
}
