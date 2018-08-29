namespace ConsoleApp.Problems
{
	public class Problem7 : ProblemBase<int>
	{
		public override int Solve()
		{
			const int input = 10001;

			var result = 0;
			var primeCount = 0;

			for (var number = 2; primeCount < input; number++)
			{
				if (CheckIfPrime(number))
				{
					primeCount++;
					result = number;
				}
			}

			return result;
		}

		private bool CheckIfPrime(int number)
		{
			for (var divisor = 2; divisor < number; divisor++)
			{
				if (number % divisor == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}