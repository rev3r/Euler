using System;
using ConsoleApp.Helpers;

namespace Euler
{
	public class Program
	{
		private static void Main(string[] args)
		{
			Console.Write("Which problem to execute: ");
			var number = int.Parse(Console.ReadLine());

			Console.Clear();
			Console.WriteLine("Number:\t\t" + number);

			var (result, time) = ExecuteProblemHelper.Execute(number);
			Console.WriteLine("Result:\t\t" + result);
			Console.WriteLine($"Time [ms]:\t{time}");
		}
	}
}