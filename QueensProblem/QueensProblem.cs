namespace QueensProblem
{
	internal class QueensProblemSolver(int n)
	{
		public List<int[]> Solutions = new List<int[]>();

		public void Solve(IEnumerable<int>? queens = null)
		{
			if (queens == null)
			{
				DateTime start = DateTime.Now;
				Solve(Enumerable.Empty<int>());
				Console.WriteLine($"{Solutions.Count} solutions found in {(DateTime.Now - start).TotalMilliseconds} ms");
				/*foreach(var solution in solutions)
                {
                    PrintQueens(solution);
                }*/
				return;
			}

			if (queens.Count() == n)
			{
				Solutions.Add(queens.ToArray());
				return;
			}
			int x = queens.Count();
			foreach (int y in Enumerable.Range(0, n).Where(testy => Safe(x, testy, queens)))
			{
				Solve(queens.Append(y));
			}
		}

		private static bool Safe(int x, int testy, IEnumerable<int> queens)
		{
			return !queens.Zip(Enumerable.Range(0, queens.Count())).Any(q => q.Second == x || q.First == testy || Math.Abs(q.Second - x) == Math.Abs(q.First - testy));
		}

		public void PrintQueens(IEnumerable<(int x, int y)> queens)
		{
			for (int y = 0; y < n; y++)
			{
				for (int x = 0; x < n; x++)
				{
					Console.Write(queens.Any(q => q.x == x && q.y == y) ? 'Q' : '.');
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
