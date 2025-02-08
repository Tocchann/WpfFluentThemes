# .NET 9 世代の WPF で変わった部分をおさらいしよう

## アジェンダ

- WPF for .NET 9 の主な変更点
- 新しいUIが導入に伴う変化
- field プロパティ導入による可読性の向上
- BinaryFormatter のサポート終了に伴う変化
- まとめ

## WPF for .NET 9 の主な変更点

- Fluent UI テーマの組み込み対応
- ThemeMode の導入
- Windows アクセントカラーのサポート
- ハイフンベースの合字サポート
- BinaryFormatter のサポート終了
- field プロパティの追加(現在プレビュー)

詳しくは[WPF for .NET 9 の新機能](https://learn.microsoft.com/ja-jp/dotnet/desktop/wpf/whats-new/net90?WT.mc_id=DT-MVP-32182&view=netdesktop-9.0)を参照

## Fluent UI テーマの組み込み対応

- 見た目の変化に伴う変更点
- レイアウトの考え方が変わった個所
- 使えなくなった設定
- アクセントカラーの定義

## 見た目の変化に伴う変更点

- Label/TextBox/TextBlock の高さが同じになった(レイアウトしやすくなったかも)
- ListBox と ListView の選択状態が異なる形に変更された
    - Fluent UI で利用する場合は、ListView を使うほうが良い
- RadioButton の無効状態はコントロール全域が塗りつぶし
- CheckBox の矩形グラフィックは一回り大きくなった
    - 標準的なテキストサイズならボタン部分のほうが大きい

## レイアウトの考え方が変わった個所

- ボタンレイアウトが大幅に変わった
- 従来
    - 親から提供される領域を全て利用する
- Fluent UI
    - ボタンコンテンツの大きさを最大値とする
    - 縦方向は中央寄せ、横方向は左寄せ
    - Gridパネルで領域計算していると想定外の位置に来る

## 使えなくなった設定

- ListView-GridView が使えなくなった
- 現状代替は DataGrid で、ReadOnlyモードにすることくらいしかない

## アクセントカラーの定義

- DynamicResource として各種アクセントカラーが導入された。
- DynamicResource なので状態変更に伴い変化する
- 色だけではなく、コントロールにもスタイルが用意されている

## field プロパティ導入による可読性の向上

- まだ、正式ではないので .csproj に`<LangVersion>preview</LangVersion>`が必要
- SourceGenerator を使っている場合に有利
    - 自分で記述する場合でも利用可能
    - 手書きにメリットがあるわけではない
- CommunityToolkit.MVVM で利用している
    - field プロパティを使って自動生成することで、SourceGenerator による自動生成が可能になった

## BinaryFormatter のサポート終了に伴う変化

- クリップボードなどに保存している場合などで影響が出る「***場合がある***」
    - クリップボードへのデータ格納に DataFormats.Serializable やカスタム形式を利用している場合に影響
- 元がプリミティブな型であればほぼ影響しない
    - string や DateTime、bool、intなどは影響しない
- ファイルの場合はバイナリダンプをする
- クリップボードなら、Nativeアプリのクリップボードビュワーを利用する

## そのほかの .NET 周りの変更点

- .NET 9 関連
- .NET MAUI 関連

## まとめ

- WPF のフレームワーク単体で UWP と同じ Fluent UI が利用可能になった
    - WinUI 3 との親和性向上への第一歩
- 既存のフレームワークの対応はこれから
    - アクティブなフレームワークのリポジトリを見る限りこれから