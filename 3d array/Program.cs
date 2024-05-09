using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3d_array
{
	internal class Program
	{
		

		static void Main(string[] args)
		{
			int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4,   5,  6 } },
						{ { 7, 8, 9 }, { 10, 11, 12 } } };
			System.Console.WriteLine("The 3D array is:");
			for (int i = 0; i < array3D.GetLength(0); i++)
			{
				for (int j = 0; j < array3D.GetLength(1); j++)
				{
					for (int k = 0; k < array3D.GetLength(2); k++)
					{

					
						System.Console.WriteLine("Element({0},{1},{2})={3}", i, j, k, array3D[i, j, k]);

					}
				}
			}

			Console.ReadLine();
		}
	

	}
	
}
	


