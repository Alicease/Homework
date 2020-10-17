using System;
using System.Linq;

namespace _4323
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1= new int [10];
            int[] arr2 = new int[10];
            Random ran = new Random();
            for (int x=0; x<arr1.Length; x++)
            {
                arr1[x] = ran.Next();
                Console.Write("{0}\t", arr1[x]);
            }
            for (int x = 0; x < arr2.Length; x++)
            {
                arr1[x] = ran.Next();
                Console.Write("{0}\t", arr2[x]);
            }
            bool result = arr1.SequenceEqual(arr2);
            Console.WriteLine("Arrays equal? {0}", result);
        }
    }
}
