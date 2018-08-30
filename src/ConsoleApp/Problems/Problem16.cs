using System.Collections.Generic;

namespace ConsoleApp.Problems
{
	public class Problem16 : IProblem<int>
	{
		public int Solve()
		{
			var digits = CalcualtePowers(1000);

			return SumDigits(digits);
		}

		private static List<int> CalculatePower(List<int> digits)
		{
			digits.Reverse();

			var result = new List<int>();
			var remainder = 0;

			foreach (var digit in digits)
			{
				var temp = (digit * 2) + remainder;
				remainder = temp / 10;

				result.Add(temp - (remainder * 10));
			}

			if (remainder > 0)
			{
				result.Add(remainder);
			}

			result.Reverse();

			return result;
		}

		private List<int> CalcualtePowers(int max)
		{
			var digits = new List<int>() { 1 };

			for (var i = 0; i < max; i++)
			{
				digits = CalculatePower(digits);
			}

			return digits;
		}

		private int SumDigits(List<int> digits)
		{
			var sum = 0;

			foreach (var digit in digits)
			{
				sum += digit;
			}

			return sum;
		}
	}
}