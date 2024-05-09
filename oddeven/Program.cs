using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var SquareNo = array.Select(x => x * x);
            Console.WriteLine("Square value  of the element of the list is:\n");    
            foreach (var x in SquareNo)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Even value of the list is:\n");
            var evenNo = array.ToList().FindAll(x => x % 2 == 0); //to use find all we converted arry into list
            foreach (var s in evenNo)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            
        }
    }
}
