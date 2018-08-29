namespace ConsoleApp.Problems
{
	public class Problem9 : ProblemBase<int>
	{
		public override int Solve()
		{
			const int max = 1000;

			for (var a = 1; a < max; a++)
			{
				for (var b = a + 1; b < max; b++)
				{
					for (var c = b + 1; c < max; c++)
					{
						if ((a * a) + (b * b) == (c * c) &&
							a + b + c == max)
						{
							return a * b * c;
						}
					}
				}
			}

			return default;
		}
	}
}