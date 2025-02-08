using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfThemeMode;
#pragma warning disable WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。

public partial class ViewModel : ObservableRecipient
{
	// 実装に field プロパティを使うので、.csproj に <LangVersion>preview</LangVersion> が必要
	[ObservableProperty]
	public partial int Counter { get; set; }

	[ObservableProperty]
	public partial WpfDefaultTheme.ListItem SelectedItem { get; set; }

	[ObservableProperty]
	[NotifyPropertyChangedRecipients]
	public partial ThemeMode ThemeMode { get; set; }

	public ObservableCollection<WpfDefaultTheme.ListItem> Items { get; } = new();

	[RelayCommand]
	void IncrementCounter() => Counter++;

	public ViewModel()
	{
		Counter = 0;
		ThemeMode = ThemeMode.System;
		Items.Add( new( "Item 1", "SubItem 1", 1, true ) );
		Items.Add( new( "Item 2", "SubItem 2", 2, true ) );
		Items.Add( new( "Item 3", "SubItem 3", 3, false ) );
		SelectedItem = Items[0];
	}
}
#pragma warning restore WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。
