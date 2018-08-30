namespace ConsoleApp.Problems
{
	public class Problem6 : IProblem<int>
	{
		public int Solve()
		{
			const int input = 100;

			return SquareOfSums(input) - SumOfSquares(input);
		}

		private int SquareOfSums(long max)
		{
			var sum = 0;

			for (var i = 1; i <= max; i++)
			{
				sum += i;
			}

			return sum * sum;
		}

		private int SumOfSquares(long max)
		{
			var result = 0;

			for (var i = 1; i <= max; i++)
			{
				result += i * i;
			}

			return result;
		}
	}
}