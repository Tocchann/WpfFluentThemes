# .NET バージョンアップグレード

## Strategy
**Selected**: All-at-Once
**Rationale**: 2つの独立したWPFプロジェクト、相互依存なし、単純なフレームワークバージョンアップグレード

### Execution Constraints
- 両プロジェクトを同時にアップグレード
- 統合ビルド検証（ソリューション全体のビルド成功を確認）
- パッケージ互換性への対応：Microsoft.Xaml.Behaviors.Wpf の互換バージョンへの更新が必須

## Preferences
- **Flow Mode**: Automatic
- **Target Framework**: .NET 10 (LTS)
- **Commit Strategy**: After Each Task

## Source Control
- **Source Branch**: master
- **Working Branch**: upgrade-dotnet-10
- **Branch Sync**: Auto (Merge)
