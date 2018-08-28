using System;
using System.Diagnostics;
using System.Reflection;
using static System.Console;

namespace Euler
{
	internal class Program
	{
		private static (string solution, double time) ExecuteProblem(int number)
		{
			var type = Assembly.GetExecutingAssembly()
				.GetType("Euler.Problems.Problem" + number);

			var sw = Stopwatch.StartNew();
			var instance = Activator.CreateInstance(type);
			sw.Stop();

			var result = type
				.GetProperty("Solution")
				.GetValue(instance, null)
				.ToString();

			return (result, sw.Elapsed.TotalMilliseconds);
		}

		private static void Main(string[] args)
		{
			Write("Which problem to execute: ");
			var number = int.Parse(ReadLine());

			Clear();
			WriteLine("Number:\t" + number);

			var (result, time) = ExecuteProblem(number);
			WriteLine("Result:\t" + result);
			WriteLine($"Time:\t{time}ms");
		}
	}
}