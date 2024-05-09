using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
	internal class Program
	{
		public struct student
		{
			public string Name { get; set; }
			public int Grade { get; set; }
			public int Age { get; set; }
			public string Address { get; set; }


			public student(string name, int grade, int age, string address)
			{
				Name = name;
				Grade = grade;
				Age = age;
				Address = address;
			}
			static void Main(string[] args)
			{
				Console.WriteLine("Enter the name of a student:");
				string sname = Console.ReadLine();
				Console.WriteLine("Enter the class of a student:");
				int sgrade = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter the age of a student:");
				int sage = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter the address of a student:");
				string sadd = Console.ReadLine();

				var student = new student(sname, sgrade, sage, sadd);
				Console.WriteLine($"Name:{student.Name}");
				Console.WriteLine($"Grade:{student.Grade}");
				Console.WriteLine($"Age:{student.Age}");
				Console.WriteLine($"Address:{student.Address}");
				Console.ReadLine();
			}
		}
	}
}
