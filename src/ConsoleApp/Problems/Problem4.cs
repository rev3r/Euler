namespace ConsoleApp.Problems
{
	public class Problem4 : IProblem<int>
	{
		public int Solve()
		{
			const int input = 999;

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