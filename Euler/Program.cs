using System;
using System.Reflection;
using static System.Console;

namespace Euler
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Write("Problem to execute (nr): ");

			var choice = int.Parse(ReadLine());
			var solution = GetSolution(choice);

			WriteLine(solution);
			WriteLine();
		}

		private static object GetSolution(int number)
		{
			var assembly = Assembly.GetExecutingAssembly();
			var type = assembly.GetType("Euler.Problems.Problem" + number);

			var property = type.GetProperty("Solution");
			var instance = Activator.CreateInstance(type);

			return property.GetMethod.Invoke(instance, null);
		}
	}
}