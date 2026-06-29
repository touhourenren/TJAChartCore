# TJAChartCore - .tja譜面読み込み・再生用ライブラリ
.tjaを読み込み、再生するためのライブラリです。  
再生といいつつ、当面の間は読み込み機能(とちょっとしたノーツ判定関数)のみを置いておきます。
TJAPlayer3で再生できるギミックにいくつか対応しています。(#SUDDEN, #JPOSSCROLLなど)

## How to Use
意味があるかはわかりませんが一応簡易的なコードを置いておきます。
```C#
TjaChartParser parser = new TjaChartParser();

string songPath = "C:\hoge.tja";
LoadType loadType = LoadType.Normal;
Song songData = parser.GetSongDataFromTja(songPath, loadType);
```

## 免責事項
- このライブラリに「描画機能」は搭載していません。
- このライブラリを使用した際に発生する問題に関する対応は行いません。予めご了承ください。
