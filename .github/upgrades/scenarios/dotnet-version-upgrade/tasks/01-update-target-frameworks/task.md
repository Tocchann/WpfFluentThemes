# 01-update-target-frameworks: ターゲット フレームワークの更新

両方の WPF プロジェクトのターゲット フレームワークを net9.0-windows から net10.0-windows に更新します。

## Scope Inventory

**Projects affected:**
1. **WpfThemeMode.csproj**
   - Current: `net9.0-windows10.0.22000.0` (Windows 10 API level 22000 を指定)
   - Target: `net10.0-windows10.0.22000.0` (Windows API レベル指定を維持)
   - Platform-specific TargetFramework のため、修正時にも API レベルを保持

2. **WpfDefaultTheme.csproj**
   - Current: `net9.0-windows`
   - Target: `net10.0-windows`
   - シンプルな置き換え

**Assessment Context:**
- バイナリ互換性警告: 57件（Api.0001）- ほとんどは再コンパイルで解決
- 動作変更の可能性: 18件（Api.0003）- 実装レベルでの対応が必要な場合がある
- 両プロジェクトとも Difficulty = Low

**Project Characteristics:**
- 両方ともSDK スタイルのWPFアプリケーション
- LangVersion = preview に設定されている
- CommunityToolkit.Mvvm を使用（.NET 10 互換）
- WpfDefaultTheme は Microsoft.Xaml.Behaviors.Wpf v1.1.135 を使用（互換性あり）

**Known Issues to Address:**
- Microsoft.Xaml.Behaviors.Wpf: バージョン 1.1.135 は .NET 10 での互換性に注意が必要（次のタスクで対応）

## Change Actions

1. WpfThemeMode.csproj: `net9.0-windows10.0.22000.0` → `net10.0-windows10.0.22000.0`
2. WpfDefaultTheme.csproj: `net9.0-windows` → `net10.0-windows`
3. NuGet パッケージの復元と検証
4. ソリューション全体のビルド検証

**Done when**: 
- 両プロジェクトが .NET 10 をターゲット
- ソリューション全体がエラーなくビルド成功
- 新しい API 警告が適切に対応される
