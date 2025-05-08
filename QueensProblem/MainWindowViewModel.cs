
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QueensProblem
{
	public class MainWindowViewModel : INotifyPropertyChanged
	{
		private List<QueensSolution> _solutions = new List<QueensSolution>();
		public List<QueensSolution> Solutions 
		{ get => _solutions;
			set
			{
				_solutions = value;
				RaisePropertyChanged();
			}
		}

		private QueensSolution _selectedSolution = new QueensSolution();
		public QueensSolution SelectedSolution
		{
			get => _selectedSolution; 
			set
			{
				_selectedSolution = value;
				RaisePropertyChanged();
			}
		}

		public MainWindowViewModel()
		{
			Solutions = new List<QueensSolution>();
			Solve();
			
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		private void RaisePropertyChanged([CallerMemberName]string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public void Solve()
		{
			QueensProblemSolver problem8 = new QueensProblemSolver(8);
			problem8.Solve();
			Solutions = problem8.Solutions.Zip(Enumerable.Range(1, problem8.Solutions.Count)).Select(pair => new QueensSolution() { Description = $"Solution {pair.Second}", QueensPositions = pair.First}).ToList();
			CurrentQueenPositions = problem8.Solutions.First();
		}

		

		public int[] CurrentQueenPositions { get; set; } = new int[8];

	}
}
