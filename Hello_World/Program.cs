using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello World");
                Console.WriteLine("\nPlease, press the button 5\n");
                char chetyre = Console.ReadKey().KeyChar;

                if (chetyre == '5')
                {
                    Console.WriteLine("\n\nCorrect");
                }
                else
                {
                    Console.WriteLine("\n\nIncorrect");
                }
                Console.ReadKey();
            }
        }
    }
}
