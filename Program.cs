using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        private static double power(double num1, int powx)
        {
            int counter = 0;
            double num2 = num1;
            for (int i = 0; i < powx; i++)
            {
                num2 = num2 * num1;
            }
            return num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number you wanna see power 2 and 3 of this :");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("power2 : ");
            Console.WriteLine(power(num, 2));
            Console.WriteLine("power3 : ");
            Console.WriteLine(power(num, 3));
            Console.ReadLine();
        }





        

    }
}
    

    

