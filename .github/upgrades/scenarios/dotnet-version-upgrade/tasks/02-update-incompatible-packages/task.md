# 02-update-incompatible-packages: 互換性のないパッケージの対応

Microsoft.Xaml.Behaviors.Wpf は現在のバージョン (1.1.135) では .NET 10 と互換性がありません。推奨バージョン 1.1.39 に更新するか、パッケージを削除して代替案を検討します。

- アセスメントで 1 件の互換性のないパッケージが検出されています
- CommunityToolkit.Mvvm (8.4.0) は .NET 10 と互換性があります

**Done when**:
- Microsoft.Xaml.Behaviors.Wpf が .NET 10 互換バージョンに更新されるか削除される
- ソリューション全体がパッケージ参照エラーなくビルド成功
- 全プロジェクトで NuGet 復元が成功
