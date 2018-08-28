using System;
using System.Reflection;

namespace Euler
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("Problem to execute (nr): ");

			var choice = int.Parse(Console.ReadLine());
			DisplaySolution(choice);
		}

		private static void DisplaySolution(int nr)
		{
			var assembly = Assembly.GetExecutingAssembly();

			var type = assembly.GetType("Euler.Problems.Problem" + nr);
			var property = type.GetProperty("Solution");

			var instance = Activator.CreateInstance(type);

			Console.WriteLine(property.GetMethod.Invoke(instance, null));
			Console.WriteLine();
		}
	}
}