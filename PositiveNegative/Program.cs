using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("palun sisesta number");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number > 0)
            {
                Console.WriteLine("Number on positiivne");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number on negativne");
            }
            else
            {
                Console.WriteLine("null");
            }






        }

    }
}
