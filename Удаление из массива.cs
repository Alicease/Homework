using System;

namespace _2323
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string buf;
            Console.Write("Enter the number of array elements");
            buf = Console.ReadLine();
            n = Convert.ToInt32(buf);
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(40);
                Console.Write("{0}", array[i]);
                Console.WriteLine();
            }
            if (n > 2)
            {
                int i = 1, j = 1;
                bool wasPos = array[0] > 0;
                while (i < (n - 1))
                {
                    if (!(wasPos && array[i] < 0 && array[i + 1] > 0));
                    {
                        array[j] = array[i]; j++;
                    }
                    wasPos = array[i] > 0; i++;


                }
                array[j] = array[i];
            }
        }

    }
}
