using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class KeyInfo
    {
        public void test3()
        {
            
            Console.WriteLine("===========");
            Console.WriteLine("=         =");
            Console.WriteLine("=    .    =");
            Console.WriteLine("=         =");
            Console.WriteLine("===========");
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("===========");
                        Console.WriteLine("=    .    =");
                        Console.WriteLine("=         =");
                        Console.WriteLine("=         =");
                        Console.WriteLine("===========");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("===========");
                        Console.WriteLine("=         =");
                        Console.WriteLine("=         =");
                        Console.WriteLine("=    .    =");
                        Console.WriteLine("===========");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("===========");
                        Console.WriteLine("=         =");
                        Console.WriteLine("=     .   =");
                        Console.WriteLine("=         =");
                        Console.WriteLine("===========");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("===========");
                        Console.WriteLine("=         =");
                        Console.WriteLine("=   .     =");
                        Console.WriteLine("=         =");
                        Console.WriteLine("===========");
                        break;

                    default:
                        break;
                }
                if(info.Key == ConsoleKey.G)
                {
                    break;
                }
            }

        }
    }
}
