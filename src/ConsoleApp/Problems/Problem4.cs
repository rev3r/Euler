namespace ConsoleApp.Problems
{
	public class Problem4 : ProblemBase
	{
		public Problem4() : base(999)
		{
		}

		protected override long Solve(long input)
		{
			var solution = 0L;

			for (var first = input; first > 99; first--)
			{
				for (var second = input; second > 99; second--)
				{
					var candidate = first * second;

					if (IsPalindrome(candidate) && candidate > solution)
					{
						solution = candidate;
					}
				}
			}

			return solution;
		}

		private bool IsPalindrome(long candidate)
		{
			var array = candidate.ToString().ToCharArray();
			var lenght = array.Length;

			int i, j;
			for (i = 0, j = lenght - 1; i < lenght / 2; i++, j--)
			{
				if (array[i] != array[j])
				{
					return false;
				}
			}

			return true;
		}
	}
}