using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = true;

            while (shouldContinue)
            {
                List<string> names = new List<string>()
                {
                    "Shark",
                    "Dave",
                    "Coco",
                    "Buttface"
                };

                Console.WriteLine("Enter your name");
                Console.WriteLine();
                string newName = Console.ReadLine();

                names.Add(newName);

                Console.WriteLine();

                for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine($"Hi {names[i]}");
                }

                Console.WriteLine();
                Console.WriteLine("Continue? y/n");
                var input = Console.ReadLine();
                if (input.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                {
                    shouldContinue = true;
                }
            }
        }
    }
}
