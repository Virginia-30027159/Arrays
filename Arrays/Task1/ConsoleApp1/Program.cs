using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string array size 3
            string[] medalwinners = new string[3]; 
            
            //Add the 3 names to the array
            Console.Write("Please enter the name of the Gold medal winner:");
            medalwinners[0] = Console.ReadLine();
            Console.Write("Please enter the name of the Silver medal winner:");
            medalwinners[1] = Console.ReadLine();
            Console.Write("Please enter the name of the Bronze medal winner:");
            medalwinners[2] = Console.ReadLine();

            //Ask the user the medal they would like to see
            Console.WriteLine("Which medal would you like to see:\n1 - Gold\n2 - Silver\n3 - Bronze");

            //Take in the user input save as an int
            int input = int.Parse(Console.ReadLine());

            //Output the appropriate medal winner using user input
            //note: need to subtract 1 from input to match correct array index
            Console.WriteLine($"The medal winner is: {medalwinners[input - 1]}" );
            Console.ReadLine();

 
        }
    }
}
