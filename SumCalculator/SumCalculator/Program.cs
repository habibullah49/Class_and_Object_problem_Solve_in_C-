// একটি ক্লাস তৈরি করুন যা দুটি পূর্ণসংখ্যা গ্রহণ করে এবং সেগুলির যোগফল প্রিন্ট করে।
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculator
{
    class Program
    {
       public class SumCalculator
        {
            public int number1;
            public int number2;

            public void Sum()
            {
                Console.WriteLine("Total sum: {0}",number1+number2);
            }
        }
        static void Main(string[] args)
        {
        

            Console.Write("Enter Your Number1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Number2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            SumCalculator total = new SumCalculator();
            total.number1 = a;
            total.number2 = b;

            total.Sum();

            Console.ReadKey();

        }
    }
}
