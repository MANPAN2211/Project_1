using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Array
    {
        int  x;
        int[] Arr;
        public void GetDetails()
        {
            Console.WriteLine("Enter array size:");
            x= Convert.ToInt32(Console.ReadLine());
            Arr = new int[x];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public void Display()
        {
            int min = Arr.Min();
            Console.WriteLine($"the minimum element:{min}");
            int max = Arr.Max();
            Console.WriteLine($"the maximum element:{max}");
        }
    }
}
