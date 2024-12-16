using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System.Diagnostics;
using System.Windows;

namespace WpfDefaultTheme;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
#pragma warning disable WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。
public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

		WeakReferenceMessenger.Default.Register<MainWindow, PropertyChangedMessage<ThemeMode>>( this, static ( window, message ) =>
		{
			// ほかにもThemeModeをやり取りするメッセンジャーを作ったら、破綻するので要注意
			Debug.Assert( message.PropertyName == "ThemeMode" );
			window.ThemeMode = message.NewValue;
		} );
	}

}
#pragma warning restore WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。
