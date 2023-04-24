using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivePrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer");
            int num=Convert.ToInt32(Console.ReadLine());

            if(IsPrime(num))
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number");
            }

            Console.ReadLine();
        }

        private static bool IsPrime(int num)
        {
          if(num <= 0)
            {
                return false;
            }

            if (num == 2)
            {
                return true;
            }

            if(num%2 == 0)
            {
                return false;
            }

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if(num%i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
