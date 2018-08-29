using System;
using System.Diagnostics;
using System.Reflection;

namespace ConsoleApp.Helpers
{
	public static class ExecuteProblemHelper
	{
		public static (string result, double time) Execute(int problemNumber)
		{
			var type = Assembly.GetEntryAssembly()
				.GetType("ConsoleApp.Problems.Problem" + problemNumber);

			var sw = Stopwatch.StartNew();
			var instance = Activator.CreateInstance(type);
			sw.Stop();

			var result = type
				.GetProperty("Solution")
				.GetValue(instance, null)
				.ToString();

			return (result, sw.Elapsed.TotalMilliseconds);
		}
	}
}