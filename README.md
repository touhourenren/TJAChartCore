# TJAChartCore - .tja譜面再生ライブラリ
.tjaを読み込み、再生するためのライブラリです。
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
