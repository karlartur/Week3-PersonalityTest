using System;

namespace PersonalityTest
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
            string userColour = Console.ReadLine();
            
            if(userColour == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if (userColour == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if (userColour == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else 
            {
            Console.WriteLine($"Oled {userColour} ükssarvik.");
            }
        }
    }
}
