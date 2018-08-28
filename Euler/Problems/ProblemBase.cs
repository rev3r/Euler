namespace Euler.Problems
{
	internal abstract class ProblemBase<TInput, TOutput>
	{
		public TOutput Solution { get; }

		public ProblemBase(TInput input)
		{
			Solution = Solve(input);
		}

		protected abstract TOutput Solve(TInput input);
	}
}