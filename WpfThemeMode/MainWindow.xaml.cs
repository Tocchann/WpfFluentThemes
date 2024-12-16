using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System.Windows;
using System.Windows.Controls;

namespace WpfThemeMode;

#pragma warning disable WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

		WeakReferenceMessenger.Default.Register<MainWindow, PropertyChangedMessage<ThemeMode>>( this, static ( window, message ) =>
		{
			window.ThemeMode = message.NewValue;
		} );
	}
}
#pragma warning restore WPF0001 // 種類は、評価の目的でのみ提供されています。将来の更新で変更または削除されることがあります。続行するには、この診断を非表示にします。
