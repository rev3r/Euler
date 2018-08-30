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
		public void ExecuteProblem10_ProperSolutionValue()
		{
			Check<Problem10>(142913828922);
		}

		[Fact]
		public void ExecuteProblem11_ProperSolutionValue()
		{
			Check<Problem11>(70600674);
		}

		[Fact]
		public void ExecuteProblem12_ProperSolutionValue()
		{
			Check<Problem12>(76576500);
		}

		[Fact]
		public void ExecuteProblem13_ProperSolutionValue()
		{
			Check<Problem13>(5537376230);
		}

		[Fact]
		public void ExecuteProblem14_ProperSolutionValue()
		{
			Check<Problem14>(837799);
		}

		[Fact]
		public void ExecuteProblem15_ProperSolutionValue()
		{
			Check<Problem15>(137846528820);
		}

		[Fact]
		public void ExecuteProblem16_ProperSolutionValue()
		{
			Check<Problem16>(1366);
		}

		[Fact]
		public void ExecuteProblem17_ProperSolutionValue()
		{
			Check<Problem17>(21124);
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

		[Fact]
		public void ExecuteProblem6_ProperSolutionValue()
		{
			Check<Problem6>(25164150);
		}

		[Fact]
		public void ExecuteProblem7_ProperSolutionValue()
		{
			Check<Problem7>(104743);
		}

		[Fact]
		public void ExecuteProblem8_ProperSolutionValue()
		{
			Check<Problem8>(23514624000);
		}

		[Fact]
		public void ExecuteProblem9_ProperSolutionValue()
		{
			Check<Problem9>(31875000);
		}

		private static void Check<TProblem>(int solution) where TProblem : IProblem<int>, new()
		{
			Assert.Equal(solution, new TProblem().Solve());
		}

		private static void Check<TProblem>(long solution) where TProblem : IProblem<long>, new()
		{
			Assert.Equal(solution, new TProblem().Solve());
		}
	}
}