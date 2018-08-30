namespace ConsoleApp.Problems
{
	public class Problem12 : IProblem<int>
	{
		public int Solve()
		{
			const int input = 500;

			for (var number = 1; true; number++)
			{
				var candidate = GenerateCandidate(number);

				if (CountDivisors(candidate) > input)
				{
					return candidate;
				}
			}
		}

		private int CountDivisors(int number)
		{
			var count = 0;
			var previous = 0;

			for (var divisor = 1; divisor < number; divisor++)
			{
				if (divisor * divisor == number)
				{
					return (count * 2) + 1;
				}

				if (previous * divisor == number)
				{
					return count * 2;
				}

				if (number % divisor == 0)
				{
					count++;
					previous = divisor;
				}
			}

			return 1;
		}

		private int GenerateCandidate(int max)
		{
			var result = 0;

			for (var i = 1; i <= max; i++)
			{
				result += i;
			}

			return result;
		}
	}
}