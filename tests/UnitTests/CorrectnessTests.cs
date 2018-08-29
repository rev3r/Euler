using ConsoleApp.Problems;
using Xunit;

namespace UnitTests
{
	public class CorrectnessTests
	{
		[Fact]
		public void ExecuteProblem1_ProperSolutionValue()
		{
			Check<Problem1>(233168);
		}

		[Fact]
		public void ExecuteProblem2_ProperSolutionValue()
		{
			Check<Problem2>(4613732);
		}

		[Fact]
		public void ExecuteProblem3_ProperSolutionValue()
		{
			Check<Problem3>(6857);
		}

		[Fact]
		public void ExecuteProblem4_ProperSolutionValue()
		{
			Check<Problem4>(906609);
		}

		[Fact]
		public void ExecuteProblem5_ProperSolutionValue()
		{
			Check<Problem5>(232792560);
		}

		private static void Check<T>(long solution)
			where T : ProblemBase, new()
		{
			var problem = new T();

			Assert.Equal(solution, problem.Solution);
		}
	}
}