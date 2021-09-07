using System;

namespace PermanentDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("mis on teie vanus");
            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int age = 2021 - YearOfBirth

                if (age > 18)
                {
                Console.WriteLine("te olete piisavalt vana et juhiluba teha");
            }
                else if (age <18)
            {
                Console.WriteLine("te olete liiga noor et juhiluba teha");
            }
                else
            {
                Console.WriteLine("te olete õiges vanuses et juhiluba teha");
            }
                Console.WriteLine("ilusat päeva")



        }
    }
}
