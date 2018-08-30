namespace ConsoleApp.Problems
{
	public interface IProblem<TResult>
	{
		TResult Solve();
	}
}