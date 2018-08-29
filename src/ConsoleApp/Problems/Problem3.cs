using System;

namespace ConsoleApp.Problems
{
	public class Problem3 : ProblemBase
	{
		public Problem3() : base(600851475143)
		{
		}

		protected override long Solve(long input)
		{
			int factor;

			var max = Math.Sqrt(input);
			for (factor = 2; input > 1; factor++)
			{
				DivideUntilPossible(ref input, factor);
			}

			return factor - 1;
		}

		private void DivideUntilPossible(ref long input, int number)
		{
			while (input % number == 0)
			{
				input /= number;
			}
		}
	}
}