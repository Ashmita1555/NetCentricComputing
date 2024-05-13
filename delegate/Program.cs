using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace @delegate
{
    //declare delegate and delegate name is calculation
    public delegate void calculation(int a, int b);
    public delegate void Area(int r);
    internal class Program
    {
        //wap to demonstrate the use of elegate to add and subtract for any two numbers.
        public  static void Addition(int x,int y)
        {
            Console.WriteLine(x + y);
        }
        public static void AreaCircle(int r)
        {
            Console.WriteLine(3.14*r*r);   
        }
        public static void Subtraction(int x,int y)
        { Console.WriteLine(x - y); }       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:\n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:\n");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  radius:\n");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The output is");
            /*single Delegate
            //addition function is bind in delegate
            calculation obj=new calculation(Addition);
            calculation obj2=new calculation(Subtraction);
            
            
            //function execution
            obj(num1, num2);
            obj2(num1, num2);*/


            //multicast delegate (calling both  the finction using single obj)
            calculation cal=new calculation(Addition);
            cal += Subtraction;
            cal.Invoke(num1, num2);
            Area area = new Area(AreaCircle);
            area(radius);
            Console.ReadLine();

            //multiple delegate (more than one delegate )
        }
    }
}
