using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading1
{
    internal class Program
    {
        public static void Disp(string s)
        {
            Console.WriteLine("display "+s);
            Console.ReadLine();
        }
        public static void Disp(int i)
        {
            Console.WriteLine("display " + i);
            Console.ReadLine();
        }
        public static void Disp(bool b)
        {
            Console.WriteLine("display " + b);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Disp(10);
            Disp(false);
            Disp("chandu");
        }
    }
}
