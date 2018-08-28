using System;

namespace Euler.Problems
{
	internal class Problem3 : ProblemBase<long, long>
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