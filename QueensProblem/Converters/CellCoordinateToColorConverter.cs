using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace QueensProblem.Converters
{
	
	public class CellCoordinateToColorConverter : MarkupExtension, IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			if(values.Length == 2 && values[0] is int columnIndex && values[1] is int rowIndex)
			{
				return (columnIndex % 2) == 0 ^ (rowIndex == 1) ? Brushes.LightBlue : Brushes.DarkGray;
			}
			return Brushes.White;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return this;
		}
	}
}
