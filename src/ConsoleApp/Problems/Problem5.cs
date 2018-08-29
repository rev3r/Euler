using System.Collections.Generic;

namespace ConsoleApp.Problems
{
	public class Problem5 : ProblemBase<int>
	{
		private List<int> divisors = new List<int>();

		public override int Solve()
		{
			const int input = 20;

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