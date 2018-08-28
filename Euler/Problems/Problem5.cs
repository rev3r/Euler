using System.Collections.Generic;

namespace Euler.Problems
{
	internal class Problem5 : ProblemBase<int, int>
	{
		private List<int> divisors = new List<int>();

		public Problem5() : base(20)
		{
		}

		protected override int Solve(int input)
		{
			divisors.Add(2);

			for (var i = 3; i <= input; i++)
			{
				var temp = i;

				DivideWhilePossible(ref temp);

				AddNewDivisors(temp);
			}

			return GetResult();
		}

		private void AddNewDivisors(int number)
		{
			if (number == 1)
			{
				return;
			}

			for (var divisor = 2; divisor <= number; divisor++)
			{
				while (number % divisor == 0)
				{
					divisors.Add(number);
					number /= divisor;
				}
			}
		}

		private void DivideWhilePossible(ref int number)
		{
			foreach (var divisor in divisors)
			{
				if (number % divisor == 0)
				{
					number /= divisor;
				}
			}
		}

		private int GetResult()
		{
			var result = 1;

			foreach (var divisor in divisors)
			{
				result *= divisor;
			}

			return result;
		}
	}
}