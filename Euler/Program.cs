using System;
using System.Diagnostics;
using System.Reflection;
using static System.Console;

namespace Euler
{
	internal class Program
	{
		private static (string solution, double time) GetSolution(int number)
		{
			var type = Assembly.GetExecutingAssembly()
				.GetType("Euler.Problems.Problem" + number);
			var instance = Activator.CreateInstance(type);
			var prop = type.GetProperty("Solution");

			var sw = Stopwatch.StartNew();
			var result = prop.GetValue(instance, null);
			sw.Stop();

			return (result.ToString(),
				sw.Elapsed.TotalMilliseconds);
		}

		private static void Main(string[] args)
		{
			Write("Which problem to execute: ");
			var choice = int.Parse(ReadLine());

			Clear();
			WriteLine("Number:\t" + choice);

			var (solution, time) = GetSolution(choice);
			WriteLine("Result:\t" + solution);
			WriteLine($"Time:\t{time}ms");
		}
	}
}