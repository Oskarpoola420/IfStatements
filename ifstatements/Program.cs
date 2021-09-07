using System;

namespace ifstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kui vana sa oled?");

            int Age = Int32.Parse(Console.ReadLine());


            if (Age > 18)
            {
                Console.WriteLine("Sa oled liiga vana");
            }
            else if (Age < 18)
            {
                Console.WriteLine("Sa oled liiga noor");
            }
            else
            {
                Console.WriteLine("Sa oledki 18");
            }

            Console.WriteLine("ilusat päeva!");




        }
    }
}
