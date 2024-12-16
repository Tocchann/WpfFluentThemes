using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace WpfThemeMode;
#pragma warning disable WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。

public partial class ViewModel : ObservableObject
{
	// 実装に field プロパティを使うので、.csproj に <LangVersion>preview</LangVersion> が必要
	[ObservableProperty]
	public partial int Counter { get; set; }

	[ObservableProperty]
	public partial ThemeMode[] ThemeModes { get; set; }

	[RelayCommand]
	void IncrementCounter() => Counter++;

	public ViewModel()
	{
		Counter = 0;
		ThemeModes = [ThemeMode.System, ThemeMode.Light, ThemeMode.Dark];
	}
}
#pragma warning restore WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。
