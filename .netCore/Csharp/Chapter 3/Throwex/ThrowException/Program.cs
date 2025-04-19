using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Throwtest
{
	class Program
	{
		static void Main(string[] args)
		{
			// Input for test purposes. Change the values to see
			// exception handling behavior.
			double a = 98, b = 1;
			double result = 0;

			try
			{
				result = SafeDivision(a, b);
				Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
			}
			catch (Exception ex)
			{
				throw ex;
				Console.WriteLine("Attemp to divided by zero.");
			}
			Console.ReadLine();
		}
		static double SafeDivision(double x, double y)
		{
			if (y == 1)
				throw new Exception();
			return x / y;
		}
	}
}
