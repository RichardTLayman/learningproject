using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(increment(42, 2));
        }

        static int increment(int i, int incrementBy = 1)
        {
            return i + incrementBy;
        }
    }
}
