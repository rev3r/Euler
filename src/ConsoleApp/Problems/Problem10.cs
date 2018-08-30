using System;
using System.Collections.Generic;

namespace ConsoleApp.Problems
{
	public class Problem10 : IProblem<long>
	{
		private List<int> divisors = new List<int>();

		public long Solve()
		{
			const int max = 2000000;

			long result = 2;
			var sqrt = (int)Math.Sqrt(max);

			divisors.Add(2);

			for (var number = 3; number < max; number += 2)
			{
				if (CheckIfPrime(number))
				{
					if (number < sqrt)
					{
						divisors.Add(number);
					}

					result += number;
				}
			}

			return result;
		}

		private bool CheckIfPrime(int number)
		{
			foreach (var divisor in divisors)
			{
				if (number % divisor == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}