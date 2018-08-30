namespace ConsoleApp.Problems
{
	public class Problem2 : IProblem<int>
	{
		public int Solve()
		{
			const int input = 4000000;

			var sum = 2;
			var last = 1;
			var current = 2;

			while (current <= input)
			{
				CalculateNextStep(ref last, ref current);
				AddIfEven(ref sum, current);
			}

			return sum;
		}

		private void AddIfEven(ref int sum, int current)
		{
			if (current % 2 == 0)
			{
				sum += current;
			}
		}

		private void CalculateNextStep(ref int last, ref int current)
		{
			var temp = last + current;
			last = current;
			current = temp;
		}
	}
}