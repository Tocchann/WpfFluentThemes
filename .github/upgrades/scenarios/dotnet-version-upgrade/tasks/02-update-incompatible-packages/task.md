# 02-update-incompatible-packages: 互換性のないパッケージの対応

Microsoft.Xaml.Behaviors.Wpf は現在のバージョン (1.1.135) では .NET 10 と互換性がありません。最新の互換バージョン 1.1.39 に更新します。

## Scope Inventory

**Projects affected:**
1. **WpfDefaultTheme.csproj**
   - Microsoft.Xaml.Behaviors.Wpf 1.1.135 → 1.1.39 (更新が必須)
   - CommunityToolkit.Mvvm 8.4.0 → 互換性あり（変更不要）

2. **WpfThemeMode.csproj**
   - Microsoft.Xaml.Behaviors.Wpf は参照されていない
   - CommunityToolkit.Mvvm 8.4.0 → 互換性あり（変更不要）

**Assessment Context:**
- 互換性のないパッケージ: 1件（NuGet.0001）
- WpfDefaultTheme のみが影響を受ける
- 他の package reference はすべて .NET 10 対応

**Package Management:**
- 標準パッケージ管理（Non-CPM）を使用
- パッケージバージョンはプロジェクトファイルで直接定義

## Change Actions

1. WpfDefaultTheme.csproj の Microsoft.Xaml.Behaviors.Wpf を 1.1.39 に更新
2. NuGet 復元と検証
3. ソリューション全体のビルド確認

**Done when**:
- Microsoft.Xaml.Behaviors.Wpf が .NET 10 互換バージョン (1.1.39) に更新される
- ソリューション全体がパッケージ参照エラーなくビルド成功
- 全プロジェクトで NuGet 復元が成功
