using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace second_time
{
    class Program
    {
        static void Main(string[] str)
        {
            string h = "Hello";
            Console.WriteLine("h= {0}", h);
            Console.WriteLine("large h = {0}", h.Length);
            Console.WriteLine("h in upper riestr = {0}" ,h.ToUpper());
            Console.WriteLine("h= {0}", h);
            Console.WriteLine("h in lower riestr = {0}", h.ToLower());
            Console.WriteLine("h= {0}", h);
            Console.WriteLine("h have e? : {0}", h.Contains ("e"));
            Console.WriteLine("change {0}" ,h.Replace ("lo",""));
            Console.WriteLine("h= {0}", h);
            Console.ReadLine();
        }
    }
}
