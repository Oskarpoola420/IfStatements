using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma lemmik värv");
            string UserColor = Console.ReadLine();

            if (UserColor == "punane")
            {
                Console.WriteLine("oled romantiline");
            }
            else if(UserColor == "sinine")
            {
                Console.WriteLine("oled töökas");
            }
            else if(UserColor == "roheline")
            {
                Console.WriteLine("oled looduse sõber");
            }
            else
            {
                Console.WriteLine("oled eriline");
            }







        }
    }
}
