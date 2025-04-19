using System;

public class Program
{
	public static void Main()
	{
		try
		{
			PerformDivisionWithThrow(10, 0);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Caught exception using 'throw':");
			Console.WriteLine(ex.ToString());
			Console.WriteLine();
		}

		try
		{
			PerformDivisionWithThrowEx(10, 0);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Caught exception using 'throw ex':");
			Console.WriteLine(ex.ToString());
		}
	}

	public static void PerformDivisionWithThrow(int numerator, int denominator)
	{
		try
		{
			int result = numerator / denominator;
		}
		catch (Exception ex)
		{
			// Log the exception (or any other handling logic)
			Console.WriteLine("Logging exception in PerformDivisionWithThrow: " + ex.Message);
			// Re-throw the exception, preserving the original stack trace
			throw;
		}
	}

	public static void PerformDivisionWithThrowEx(int numerator, int denominator)
	{
		try
		{
			int result = numerator / denominator;
		}
		catch (Exception ex)
		{
			// Log the exception (or any other handling logic)
			Console.WriteLine("Logging exception in PerformDivisionWithThrowEx: " + ex.Message);
			// Re-throw the exception, resetting the stack trace
			throw ex;
		}
	}
}
