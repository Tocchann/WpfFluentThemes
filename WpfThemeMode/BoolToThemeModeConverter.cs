using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfThemeMode;
#pragma warning disable WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。

public class BoolToThemeModeConverter : IValueConverter
{
	private ThemeModeConverter ThemeModeConverter { get; init; } = new();
	public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
	{
		var themeMode = parameter as string;
		if( themeMode == null )
		{
			return System.Windows.DependencyProperty.UnsetValue;
		}
		var obj = ThemeModeConverter.ConvertFromString( themeMode );
		if( obj == null )
		{
			return System.Windows.DependencyProperty.UnsetValue;
		}
		var themeModeValue = ThemeModeConverter.ConvertFrom( value );
		return Object.Equals( themeModeValue, obj );
	}

	public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
	{
		if( value is bool isChecked && isChecked && parameter is string paramStr )
		{
			var obj = ThemeModeConverter.ConvertFromString( paramStr );
			if( obj != null )
			{
				return (ThemeMode)obj;
			}
		}
		return System.Windows.DependencyProperty.UnsetValue;
	}
}
#pragma warning restore WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。
