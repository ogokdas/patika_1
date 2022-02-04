using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            Console.WriteLine(input);

            Console.Write("Lütfen birşeyler yazın:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Input: {0}",input2);
            
            Console.ReadLine();

        }
    }
}
