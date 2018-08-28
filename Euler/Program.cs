using System;
using System.Reflection;
using System.Transactions;
using static System.Console;

namespace Euler
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Write("Problem to execute: ");

			var choice = int.Parse(ReadLine());
			var solution = GetSolution(choice);

			WriteLine(solution);
			WriteLine();
		}

		private static object GetSolution(int number)
		{
			var type = GetProblemClassType(number);

			return GetPropertyValue(type, "Solution");
		}

		private static Type GetProblemClassType(int number)
		{
			return Assembly.GetExecutingAssembly()
				.GetType("Euler.Problems.Problem" + number);
		}

		private static object GetPropertyValue(Type type, string propertyName)
		{
			var instance = Activator.CreateInstance(type);

			return type.GetProperty(propertyName)
				.GetValue(instance, null);
		}
	}
}