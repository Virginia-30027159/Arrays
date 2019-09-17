using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a string array size 5
            string[] names = new string[5];

            //Add the 5 names to the array
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Please enter name {i + 1} : ");
                names[i] = Console.ReadLine();
            }

            //Output the appropriate names for 1 & 5 of user input
            //note: remmember to -1 to get the right index from array
            Console.WriteLine($"First name in the Array: {names[0]}");
            Console.WriteLine($"Last name in the Array: {names[4]}");

            Console.ReadLine();
        }
    }
}
