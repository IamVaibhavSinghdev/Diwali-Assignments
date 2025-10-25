using System;
using System.Collections;

namespace ArrayListSortingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList names = new ArrayList();

            Console.WriteLine("Enter 10 names:");

   
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter name {0}: ", i);
                string name = Console.ReadLine();

           
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name cannot be empty. Please enter again.");
                    i--; 
                    continue;
                }

                names.Add(name);
            }

      
            Console.WriteLine("\nNames before sorting:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

         
            names.Sort();

        
            Console.WriteLine("\nNames after sorting:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

           
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
