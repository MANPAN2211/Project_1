using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Factorial

    {
        int n, result= 1;
        public void GetDetail()
        {
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            for (int i = 1; i < n; i++)
            {
                result = result * i;
                Console.WriteLine($"{result}");
                
            }
        }

    }

}
