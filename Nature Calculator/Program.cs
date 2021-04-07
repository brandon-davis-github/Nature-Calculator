using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nature_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //loads the csv file for calculation
            var pokedex = NaturesUtility.LoadPokemon();

            //begin user input
            while (true)
            {
                string userInput;
                Console.WriteLine("Welcome to my nature calculator!\n");
                Console.Write("Please input your Pokemon: ");
                userInput = Console.ReadLine().ToLower();
                if (!pokedex.ContainsKey(userInput))
                {
                    Console.WriteLine("Sorry, I could not locate that Pokemon.\n");
                    continue;
                }
                var pokemon = pokedex[userInput];
                Console.WriteLine();
                Console.WriteLine(pokemon);
                Console.WriteLine("Recommended Nature(s): " + NatureCalculations.GetNature(pokemon));
                Console.WriteLine("\n-----------------------------------------------------------\n");

                //additional user interface for further calculations if desired
                char userSelect;
                while (true)
                {
                    Console.WriteLine("Please select an option:\n\t1 - Input another Pokemon\n\t2 - Close the program\n\t" +
                        "3 - Clear the console\n");
                    userSelect = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (userSelect == '1' || userSelect == '2' || userSelect == '3')
                    {
                        break;
                    }
                    Console.WriteLine("\nThat is not a valid selection.\n");
                }
                if (userSelect == '1')
                {
                    continue;
                }
                if (userSelect == '2')
                {
                    break;
                }
                if (userSelect == '3')
                {
                    Console.Clear();
                }        
            }
        }
    }
}