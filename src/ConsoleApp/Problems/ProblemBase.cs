namespace ConsoleApp.Problems
{
	public abstract class ProblemBase
	{
		public long Solution { get; }

		public ProblemBase(long input)
		{
			Solution = Solve(input);
		}

		protected abstract long Solve(long input);
	}
}