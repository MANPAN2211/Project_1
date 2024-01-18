using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Fbonacci
    {
        int a=0, b=1, c;
        public void GetDetails()
        {
            Console.Write($"  {a}");
            Console.Write($"  {b}");
        }
        public void DisplayDetails()
        {
            for( int i = 0; i < 15; i++ ) 
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
            }
        }
    }
}
