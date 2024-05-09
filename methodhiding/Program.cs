using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodhiding
{
	internal class Program
	{ class Calculation
		{
			public void Addition(int a, int b)
			{
				int x = a + b;
				Console.WriteLine($"Parent showing the addition of two no is: {x}");

			}
			public void Subtraction(int a, int b)
			{
				int y = a - b;
				Console.WriteLine($" Parent showing the subtraction of two no is: {y}");

			}
		}
		class childhidding: Calculation
		{
			//method hiding using new keyword
			public new void Addition(int a, int b)
			{
				int x = a + b;
				Console.WriteLine($" child showing the sum of two no is:{x}");
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter first number:\n");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second number:\n");
			int num2 = Convert.ToInt32(Console.ReadLine());
			Calculation obj = new Calculation();
			obj.Addition(num1, num2);
			obj.Subtraction(num1, num2);
			childhidding obj1 = new childhidding();
			obj1.Addition(num1, num2);
			Console.ReadLine();
		}
		
	}
}
