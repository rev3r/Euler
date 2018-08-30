using System.Numerics;

namespace ConsoleApp.Problems
{
	public class Problem15 : IProblem<long>
	{
		public long Solve()
		{
			var side = 20;

			var result = Factor(side * 2) / (Factor(side) * Factor(side));

			return (long)result;
		}

		private BigInteger Factor(int number)
		{
			BigInteger result = 1;

			for (var i = 2; i <= number; i++)
			{
				result *= i;
			}

			return result;
		}
	}
}