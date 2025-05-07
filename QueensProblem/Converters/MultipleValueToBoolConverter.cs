using System.Globalization;
using System.Windows.Data;

namespace QueensProblem.Converters
{
	public class MultipleValueToBoolConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			return values.Length == 2 && values[0] is int index && values[1] is int queenIndex && index == queenIndex;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
