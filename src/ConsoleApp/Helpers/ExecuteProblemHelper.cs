using System;
using System.Diagnostics;
using System.Reflection;

namespace ConsoleApp.Helpers
{
	public static class ExecuteProblemHelper
	{
		public static (string result, double time) ExecuteAndMeasure(int problemNumber)
		{
			var type = Assembly.GetEntryAssembly()
				.GetType("ConsoleApp.Problems.Problem" + problemNumber);
			var instance = Activator.CreateInstance(type);
			var method = type.GetMethod("Solve");

			var sw = Stopwatch.StartNew();
			var result = method.Invoke(instance, null);
			sw.Stop();

			return (result.ToString(), sw.Elapsed.TotalMilliseconds);
		}
	}
}