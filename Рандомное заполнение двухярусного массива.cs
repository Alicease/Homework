using System;

namespace _4_staff
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] RandomArr = new int [4,5];
            Random ran = new Random();
            for (int i=0; i<4; i++)
            {
                for (int j=0; j<5; j++)
                {
                    RandomArr[i,j] = ran.Next (1,100);
                    Console.Write("{0} \t", RandomArr[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
