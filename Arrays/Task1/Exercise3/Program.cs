using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the array size 5 populate with moari words chosen
            string[] maori = { "Kia ora", "Nau mai", "Aroha", "Hui", "koha" };
            string[] english = { "Hello", "Welcome", "Love", "Meeting", "Gift" };

            //Title
            Console.WriteLine("******************************************");
            Console.WriteLine("************* Translator App *************");
            Console.WriteLine("******************************************");

            Console.WriteLine("This App can Translate the following words:");
            for (int i = 0; i < english.Length; i++)
            {
                Console.WriteLine($"{i+1}. {english[i]}");
            }
            Console.Write("\nWhich word would you like translated to Maori: ");
 
            //Take in the users input as an int
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{english[input-1]} translated into maori is: {maori[input-1]}");

            Console.WriteLine("\nThankyou for using this app, press ENTER to quit...");
            Console.ReadLine();

        }
    }
}
