# .NET 9 世代の WPF で変わった部分をおさらいしよう

## アジェンダ

- WPF for .NET 9 の主な変更点
- field プロパティの導入(現在Preview)
- まとめ

## WPF for .NET 9 の主な変更点

- Fluent UI テーマの組み込み対応
- ThemeMode の導入
- Windows アクセントカラーのサポート
- ハイフンベースの合字サポート
- BinaryFormatter のサポート終了

詳しくは[WPF for .NET 9 の新機能](https://learn.microsoft.com/ja-jp/dotnet/desktop/wpf/whats-new/net90?WT.mc_id=DT-MVP-32182&view=netdesktop-9.0)を参照

## Fluent UI テーマの組み込み対応

- 見た目の変化に伴う変更点
- ボタンレイアウトの変更
- 使えなくなったモード
- アクセントカラーの導入

## 見た目の変化に伴う変更点

- Label/TextBox/TextBlock の高さが同じになった
- ListBox と ListView の選択状態が異なる形に変更された
    - Fluent UI で利用する場合は、ListView のほうが親和性は高いかも
- RadioButton の無効状態はコントロール全域を塗りつぶし
- CheckBox の矩形グラフィックは一回り大きくなった
    - 標準的なテキストサイズならボタン部分のほうが大きい

## ボタンレイアウトの変更

- ボタンレイアウト
- 従来
    - 親から提供される領域を全て利用する
- Fluent UI
    - ボタンコンテンツの大きさを最大値とする
    - 縦方向は中央寄せ、横方向は左寄せ
        - Alignment は有効
    - Gridパネルで領域計算していると想定外の位置に来る

## 使えなくなったモード

- ListView-GridView が使えなくなった(.NET10までにどうなるかは不明)
- 代替手段
    - DataGrid を ReadOnly で使う(完全互換ではない)

## アクセントカラーの導入

- DynamicResource として各種アクセントカラーが導入された。
- DynamicResource なので状態変更に伴い変化する
- 色だけではなく、コントロールにもスタイルが用意されている

## field プロパティの導入(現在Preview)

- プレビューなので .csproj に`<LangVersion>preview</LangVersion>`が必要
- SourceGenerator を使っている場合に有利
    - 自分で記述する場合でも利用可能
    - 手書きでもフィールドを定義しなくてよくなる程度の効果はある
- CommunityToolkit.MVVM で利用
    - field プロパティを使って自動生成することで、SourceGenerator による自動生成が可能になった
    - 属性との組み合わせの活用範囲が広がった

## BinaryFormatter のサポート終了に伴う変化

- クリップボードなどに保存している場合などで影響が出る「***場合がある***」
    - DataFormats.Serializable など
- 元がプリミティブな型であればほぼ影響しない
    - string や DateTime、bool、int、byte[] などは影響しない

## まとめ

- WPF のフレームワーク単体で UWP と同じような Fluent UI が利用可能になった
    - WinUI 3 との親和性向上への第一歩
- 既存のフレームワークの対応が今後の課題
    - アクティブなフレームワークのリポジトリを見る限りこれから

## 参考資料
- .NET 9 関連
- .NET MAUI 関連

