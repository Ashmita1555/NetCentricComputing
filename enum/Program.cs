using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
	internal class Program
	{ 
		public enum season
		{
			spring,
			Summer,
			Autumn,
			Winter=20
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Result of enum:\n");
			season a= season.spring;
			Console.WriteLine($"Integral value of{a} is {(int)a}");

			var b = (season)20;
			Console.WriteLine($"The season having integral value {(int)b} is {b} ");
			 
			

			Console.ReadLine();
		}
	}
}
