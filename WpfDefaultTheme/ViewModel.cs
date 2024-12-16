﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfDefaultTheme;
#pragma warning disable WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。
public partial class ViewModel : ObservableRecipient
{
	public ObservableCollection<ListItem> Items { get; } = new();

	public ObservableCollection<string> ComboItems { get; } = new();

	[ObservableProperty]
	[NotifyPropertyChangedRecipients]
	string? selectedComboItem;

	[ObservableProperty]
	[NotifyPropertyChangedRecipients]
	public partial ThemeMode ThemeMode { get; set; }

	[RelayCommand]
	void ThemeButtonClick( string themeMode )
	{
		var converter = new ThemeModeConverter();
		var obj = converter.ConvertFromString( themeMode );
		if( obj != null )
		{
			ThemeMode = (ThemeMode)obj;
		}
	}

	public ViewModel()
	{
		Items.Add( new ListItem( "Item 1", "SubItem 1", 1, true ) );
		Items.Add( new ListItem( "Item 2", "SubItem 2", 2, true ) );
		Items.Add( new ListItem( "Item 3", "SubItem 3", 3, false ) );
		ComboItems.Add( "ComboItem1" );
		ComboItems.Add( "ComboItem2" );
		ComboItems.Add( "ComboItem3" );
		ComboItems.Add( "ComboItem4" );
	}
}
#pragma warning restore WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。
