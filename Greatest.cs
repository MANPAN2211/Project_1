using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Greatest
    {
        int n1, n2,n3;
        public void GetDetails()
        {
            Console.WriteLine("Enter first number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            n3 = Convert.ToInt32(Console.ReadLine());
        }
        private int GretestNum(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > n3)
            {
                return n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                return n2;
            }
            else
            {
                return 3;
            }
        }
         public void  DisplayDetails()
        {
            int result = GretestNum(n1, n2,n3);
                Console.WriteLine($"{result} is the greatest number");
            }
           
      

       
    }
}