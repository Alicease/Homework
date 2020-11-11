using System;
namespace Evk_Nod
{
    class Program
    {
        static void Main(string[] args)

            {
            int x, y;
                Console.Write("x= ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("y= ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("НОД = {0}", NOD(x, y));
                Console.ReadKey();

            }
            static int NOD(int x, int y)
            {
                if (x < 0 || y < 0)
                {
                    x = Math.Abs(x);
                    y = Math.Abs(y);
                }
                if (x == 0 && y == 0)
                {
                    return 0;
                }
                while (x != y)
                {
                    if (x > y)
                        x = x - y;
                    else
                        y = y - x;
                }
                return x;
            }
        }
    }
