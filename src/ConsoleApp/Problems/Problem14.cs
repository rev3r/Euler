namespace ConsoleApp.Problems
{
	public class Problem14 : IProblem<int>
	{
		public int Solve()
		{
			const int max = 1000000;

			var maxCount = 0;
			var candidate = 0;

			for (var starting = 1; starting < max; starting++)
			{
				var count = CalculateCount(starting);

				if (count > maxCount)
				{
					maxCount = count;
					candidate = starting;
				}
			}

			return candidate;
		}

		private int CalculateCount(long number)
		{
			int count;
			for (count = 1; number != 1; count++)
			{
				number = NextValue(number);
			}

			return count;
		}

		private long NextValue(long number)
		{
			if (number % 2 == 0)
			{
				return number / 2;
			}
			else
			{
				return (number * 3) + 1;
			}
		}
	}
}