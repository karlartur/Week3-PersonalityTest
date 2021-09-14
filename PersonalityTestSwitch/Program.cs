using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //progamm küsib kasutajat sisestada tema lemmikvärvi;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColour = Console.ReadLine().ToLower();

            switch (userColour)
            {
                case "punane":
                    Console.WriteLine("Oled romatiline");
                    break;
                case "sinine":
             Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled ükssarvik.");
                    break;
            }
            
            Console.WriteLine("Kena päeva!");
        }
    }
}
