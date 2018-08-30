namespace ConsoleApp.Problems
{
	public class Problem17 : IProblem<int>
	{
		private int sum = 0;

		public int Solve()
		{
			const int max = 1000;

			for (var number = 1; number < max; number++)
			{
				if (number < 10)
				{
					EvaluateDigit(number);
				}
				else if (number >= 10 && number < 100)
				{
					EvaluateTens(number);
				}
				else
				{
					EvaluateHundrets(number);
				}
			}

			AddLength("onethousand");

			return sum;
		}

		private void AddLength(string text)
		{
			sum += text.Length;
		}

		private void EvaluateDigit(int digit)
		{
			var names = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

			AddLength(names[digit - 1]);
		}

		private void EvaluateHundrets(int number)
		{
			EvaluateDigit(number / 100);

			AddLength("hundred");

			if (number % 100 > 0)
			{
				AddLength("and");

				var lastTwoDigits = number - (number / 100 * 100);
				if (lastTwoDigits < 10)
				{
					EvaluateDigit(lastTwoDigits);
				}
				else
				{
					EvaluateTens(lastTwoDigits);
				}
			}
		}

		private void EvaluateTens(int number)
		{
			if (number == 10)
			{
				AddLength("ten");
			}
			else if (number > 10 && number < 20)
			{
				if (number == 11 || number == 12)
				{
					AddLength("eleven");
				}
				else
				{
					GetLastDigitAndEvaluate(number);

					if (number == 13 || number == 15 || number == 18)
					{
						sum--;
					}

					AddLength("teen");
				}
			}
			else if (number >= 20 && number < 30)
			{
				AddLength("twenty");

				if (number > 20)
				{
					GetLastDigitAndEvaluate(number);
				}
			}
			else
			{
				EvaluateDigit(number / 10);

				if ((number >= 30 && number <= 59) || (number >= 80 && number <= 89))
				{
					sum--;
				}

				AddLength("ty");

				if (number % 10 > 0)
				{
					GetLastDigitAndEvaluate(number);
				}
			}
		}

		private void GetLastDigitAndEvaluate(int number)
		{
			EvaluateDigit(number - (number / 10 * 10));
		}
	}
}