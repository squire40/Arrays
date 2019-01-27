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
            string[] names = new string[4];

            names[0] = "Shark";
            names[1] = "Dave";
            names[2] = "Coco";
            names[3] = "Buttface";

            Console.WriteLine("Enter your name");
            Console.WriteLine();
            string newName = Console.ReadLine();

            names[4] = newName;

            Console.WriteLine();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Hi {names[i]}");
            }
        }
    }
}
