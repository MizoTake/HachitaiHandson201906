# 201906 八耐ハンズオン

## 作業環境
Unity2018.4.0f1

## Project構造

```
└── Assets
    └── TankGameSample
        ├── Extra (Game.unityを拡張したサンプルを入れたフォルダ)
        │   ├── AutoSpawn (敵戦車が自動的に生成されるようにしたサンプル)
        │   ├── NavMesh (Unityの機能であるNavMeshを使用して移動範囲を制限させたサンプル)
        │   ├── ScriptableObject (Unityの機能であるScriptableObjectでデータを保持させて扱うサンプル)
        │   ├── Timeline (Unityの機能であるTimelineを使ったゲームスタート演出を追加したサンプル)
        │   └── TransitionScene (タイトル画面からゲーム画面に移動するサンプル)
        ├── Game.unity
        ├── Handson (ハンズオン用に簡易化した戦車ゲームが入ったフォルダ)
        ├── Material (ベースとなる戦車の色などを保持させるデータが入ったフォルダ)
        ├── Prefab (戦車のモデルとなるデータが入ったフォルダ)
        └── Script (戦車を動かしたり弾を撃つ処理を書いたソースコードが入ったフォルダ)
```