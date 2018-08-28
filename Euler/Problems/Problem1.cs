﻿namespace Euler.Problems
{
	internal class Problem1 : ProblemBase<int, int>
	{
		public Problem1() : base(1000)
		{
		}

		protected override int Solve(int input)
		{
			var sum = 0;

			for (var i = 2; i < input; i++)
			{
				AddIfDivisble(ref sum, i);
			}

			return sum;
		}

		private void AddIfDivisble(ref int sum, int number)
		{
			if (number % 3 == 0 || number % 5 == 0)
			{
				sum += number;
			}
		}
	}
}