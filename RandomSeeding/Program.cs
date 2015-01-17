using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSeeding
{
    class Program
    {
        static int userInputX, userInputY, seed;
        
        static void Main()
        {
            UserInput();

            if (userInputY >= 2)
            {
                Array2D(seed);
            }
            else
            {
                single(seed);
            }
                
            exit();
        }
        static void UserInput()
        {
            Console.WriteLine("Enter how many Rows to randomize?");
            var temp = Console.ReadLine();
            userInputX = Int32.Parse(temp);
            Console.WriteLine("Enter how many Columns to randomize?");
            temp = Console.ReadLine();
            userInputY = Int32.Parse(temp);
            Console.WriteLine("Enter Seed");
            temp = Console.ReadLine();
            seed = Int32.Parse(temp);
        }
        static void Array2D(int seed)
        {
            Random _r = new Random(seed);
            int[,] array = new int[userInputX, userInputY];
            
            var x = 0;
            for (int iX = 1; iX < userInputX + 1; iX++)
            {
                var y = 0;
                for (int iY = 1; iY < userInputY + 1; iY++)
                {
                    int _random = _r.Next(100);
                    array[x, y] = _random;

                    Console.Write(" " + _random);
                    if(y == userInputY - 1)
                    {
                        Console.WriteLine("\n");
                    }
                    y++;
                }                
                x++;
            }
            Console.WriteLine("Generated at: {0:hh:mm:sstt on MM-dd-yyyy}", DateTime.Now);
            
        }
        static void single(int seed) 
        {
            Random _r = new Random(seed);
            for (int i = 1; i < userInputX + 1; i++)
            {
                var _random = _r.Next(100);
                Console.WriteLine(i + ": " + _random);
            }
        }
        static void exit()
        {
            //hold console open for user input
            Console.WriteLine("\n**************************\n* Press any key to exit. *\n**************************");
            var exit = Console.ReadLine();
        }
    }
}
