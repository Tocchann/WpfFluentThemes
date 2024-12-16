using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WpfDefaultTheme;

public partial class ListItem : ObservableObject
{
	[ObservableProperty]
	string item;

	[ObservableProperty]
	string subItem;

	[ObservableProperty]
	int subItem2;

	[ObservableProperty]
	bool subItem3;

	public ListItem( string item, string subItem, int subItem2, bool subItem3 )
	{
		Item = item;
		SubItem = subItem;
		SubItem2 = subItem2;
		SubItem3 = subItem3;
	}
}
