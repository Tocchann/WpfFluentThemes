# .NET バージョンアップグレード計画

## Overview

**Target**: WpfFluentThemes を .NET 9 から .NET 10 にアップグレード
**Scope**: 2つのWPFプロジェクト、約200行のコード、軽微な依存関係

このアップグレードでは、両方のWPFプロジェクト（WpfDefaultTheme と WpfThemeMode）を同時に .NET 10 (LTS) に移行します。

## Strategy

**Selected**: All-at-Once

アセスメント結果から、両方のプロジェクトは相互に独立した WPF アプリケーションで、.NET 9 から .NET 10 への移行は単純な互換性アップグレードです。問題の大部分は API のバイナリ互換性に関する警告で、再コンパイルで解決します。

**Execution Constraints**
- 両方のプロジェクトを同時にアップグレード
- 統合的な検証：ソリューション全体のビルド成功を確認
- パッケージの互換性の確認：Microsoft.Xaml.Behaviors.Wpf は互換性がないため対応が必要

## Tasks

### 01-update-target-frameworks: ターゲット フレームワークの更新

両方の WPF プロジェクトのターゲット フレームワークを net9.0-windows から net10.0-windows に更新します。

- **WpfDefaultTheme.csproj**: `<TargetFramework>net10.0-windows</TargetFramework>` に変更
- **WpfThemeMode.csproj**: `<TargetFramework>net10.0-windows10.0.22000.0</TargetFramework>` に変更（Windows 10 API レベルの指定を維持）

アセスメントより、57件のバイナリ互換性警告（Api.0001）と18件の動作変更の可能性（Api.0003）が検出されています。これらの大部分は再コンパイルで解決します。

**Done when**: 
- 両プロジェクトが .NET 10 をターゲット
- ソリューション全体がエラーなくビルド成功
- 新しい API 警告が適切に対応される

### 02-update-incompatible-packages: 互換性のないパッケージの対応

Microsoft.Xaml.Behaviors.Wpf は現在のバージョン (1.1.135) では .NET 10 と互換性がありません。推奨バージョン 1.1.39 に更新するか、パッケージを削除して代替案を検討します。

- アセスメントで 1 件の互換性のないパッケージが検出されています
- CommunityToolkit.Mvvm (8.4.0) は .NET 10 と互換性があります

**Done when**:
- Microsoft.Xaml.Behaviors.Wpf が .NET 10 互換バージョンに更新されるか削除される
- ソリューション全体がパッケージ参照エラーなくビルド成功
- 全プロジェクトで NuGet 復元が成功

### 03-validate-and-test: 検証とテスト

すべてのプロジェクトで完全なビルド検証と機能テストを実行します。API の動作変更（Api.0003）のうち、実装で対応が必要なものがないか確認します。

- 完全なクリーンビルド実行
- すべてのプロジェクトのビルド警告確認と解決
- .NET 10 の破壊的変更確認：WPF 関連の既知の変更を確認

**Done when**:
- 全プロジェクトが警告なくビルド成功
- すべてのテストが成功
- .NET 10 互換性の確認が完了
