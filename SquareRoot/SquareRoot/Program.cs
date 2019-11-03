using System;

namespace SquareRoot
{
	class Program
	{
		static void Main(string[] args)
		{
			double a, b, c, d, x1, x2;
			Console.Write("Enter a: ");
			a = double.Parse(Console.ReadLine());
			Console.Write("Enter b: ");
			b = double.Parse(Console.ReadLine());
			Console.Write("Enter c: ");
			c = double.Parse(Console.ReadLine());
			d = b * b - 4 * a * c;
			if (a == 0)
			{
				//straight line
				Console.WriteLine("It's straight line equation");
			}
			else
			{
				//quadratic equation
				if (d >= 0)
				{
					x1 = (-b + Math.Sqrt(d)) / 2 * a;
					x2 = (-b - Math.Sqrt(d)) / 2 * a;
					Console.WriteLine("x1 = {0} and x2 = {1}", x1, x2);
				}
				else
				{
					Console.WriteLine("No Real Solution");
				}
			}

		}
	}
}
