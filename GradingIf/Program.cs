using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma hinne:");
            int UserNumber = Convert.ToInt32(Console.ReadLine());
            if (UserNumber == 5)
            {
                Console.WriteLine("Suurepärane");
            }
            else if (UserNumber == 4)
            {
                Console.WriteLine("Väga hea");
            }
            else if (UserNumber == 3)
            {
                Console.WriteLine("Hea");
            }
            else if (UserNumber == 2)
            {
                Console.WriteLine("Rahuldav");
            }
            else 
            {
                Console.WriteLine("Puudulik");
            }
        }
    }
}
