# WpfMVVMStudy

コードを ViewModel に書いた MVVM の場合と、 View(Window) の CodeBehind に書いた場合のプロジェクトを用意して、差異を確認する。

 プロジェクト名  |     プロジェクトの種類
---------------- | ---------------------------
WpfMVVM          | CommunityToolkit.Mvvm を追加。 SampleModule を取り込み。
WpfCodeBehind    | 追加パッケージ無し。 SampleModule を取り込み。
SampleModule     | 共通クラスを定義。
TestSampleModule | xUnit テスト プロジェクト

## WpfMVVM

コードを ViewModel に書いた MVVM の場合のプロジェクト。

## WpfCodeBehind

コードを View(Window) の CodeBehind に書いた場合のプロジェクト。

## SampleModule

Model や 共通で使えるクラスを用意したプロジェクト。

## TestSampleModule

SampleModule のテストプロジェクト。