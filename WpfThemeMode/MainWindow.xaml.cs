using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System.Windows;
using System.Windows.Controls;

namespace WpfThemeMode;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
		// 現在のテーマモードで初期化しておく
		((ViewModel)DataContext).ThemeMode = ThemeMode;

		// ThemeMode はDependencyPropertyではないので、Messenger 経由で受け取ってViewに反映する
		WeakReferenceMessenger.Default.Register<MainWindow, PropertyChangedMessage<ThemeMode>>( this, static ( window, message ) =>
		{
			window.ThemeMode = message.NewValue;
		} );
	}
}
