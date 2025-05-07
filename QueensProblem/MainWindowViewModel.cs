
namespace QueensProblem
{
	public class MainWindowViewModel
	{
		List<int[]> Solutions { get; set; }
		public MainWindowViewModel()
		{
			Solutions = new List<int[]>();
			QueensProblemSolver problem8 = new QueensProblemSolver(8);
			problem8.Solve();
			CurrentQueenPositions = problem8.Solutions.First();
		}

		private void BuildQueenSolutions()
		{
			
		}

		public int[] CurrentQueenPositions { get; set; } = new int[8];

	}
}
