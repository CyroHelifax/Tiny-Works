using System;

namespace DancingCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@" /\_/\ ");
            Console.WriteLine(@"( o.o )");
            Console.WriteLine(@"> ^ <");
            Console.WriteLine();
            Console.WriteLine("Press any key to dance!");
            Console.ReadKey();
            Console.Clear();

            int danceMove = 1;
            while (true)
            {
                switch (danceMove)
                {
                    case 1:
                        Console.WriteLine(@" /\_/\ ");
                        Console.WriteLine(@"( o.o ) >");
                        Console.WriteLine(@" > ^ < ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(150);
                        Console.Clear();
                        danceMove = 2;
                        break;
                    case 2:
                        Console.WriteLine(@" /\_/\ ");
                        Console.WriteLine(@"( o.o )");
                        Console.WriteLine(@" > ^ <");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(150);
                        Console.Clear();
                        danceMove = 3;
                        break;
                    case 3:
                        Console.WriteLine(@" /\_/\ >");
                        Console.WriteLine(@"( o.o )");
                        Console.WriteLine(@" > ^ <");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(150);
                        Console.Clear();
                        danceMove = 4;
                        break;
                    case 4:
                        Console.WriteLine(@" /\_/\ ");
                        Console.WriteLine(@"( o.o )");
                        Console.WriteLine(@"> ^ < ");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(150);
                        Console.Clear();
                        danceMove = 5;
                        break;
                    case 5:
                        Console.WriteLine(@" /\_/\ ");
                        Console.WriteLine(@"( o.o )");
                        Console.WriteLine(@"> ^ < >");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(150);
                        Console.Clear();
                        danceMove = 1;
                        break;
                }
            }
        }
    }
}
