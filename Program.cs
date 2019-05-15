using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delenie
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0;
            var p2 = 0;
            var p3 = 0;
            for (int i = 1; i <= n; i++)
            {
                var a = int.Parse(Console.ReadLine());
                if (a % 2 == 0) p1++;
                if (a % 3 == 0) p2++;
                if (a % 4 == 0) p3++;
            }
            var p1p = p1 * 100.0 / n;
            var p2p = p2 * 100.0 / n;
            var p3p = p3 * 100.0 / n;
            Console.WriteLine("{0:f2}%", p1p);
            Console.WriteLine("{0:f2}%", p2p);
            Console.WriteLine("{0:f2}%", p3p);

        }
    }
}
