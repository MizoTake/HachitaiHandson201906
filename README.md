# 201906 八耐ハンズオン

## 作業環境
Unity2018.4.0f1

## Project構造

```
└── Assets
    └── TankGameSample
        ├── Extra (Game.unityを拡張したサンプルを入れたフォルダ)
        │   ├── Audio
        │   ├── AutoSpawn (敵戦車が自動的に生成されるようにしたサンプル)
        │   ├── NavMesh (Unityの機能であるNavMeshを使用して移動範囲を制限させたサンプル)
        │   ├── ScriptableObject (Unityの機能であるScriptableObjectでデータを保持させて扱うサンプル)
        │   ├── Timeline
        │   └── TransitionScene (タイトル画面からゲーム画面に移動するサンプル)
        ├── Game.unity
        ├── Material (ベースとなる戦車の色などを保持させるデータが入ったフォルダ)
        ├── Prefab (戦車のモデルとなるデータが入ったフォルダ)
        └── Script (戦車を動かしたり弾を撃つ処理を書いたソースコードが入ったフォルダ)
```

## その他リンク
// TODO: githubリンクとか?