namespace Euler.Problems
{
	internal class Problem4 : ProblemBase<int, int>
	{
		public Problem4() : base(999)
		{
		}

		protected override int Solve(int input)
		{
			var solution = 0;

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

		private bool IsPalindrome(int candidate)
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