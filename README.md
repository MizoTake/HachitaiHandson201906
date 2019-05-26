# 201906 八耐ハンズオン

## 作業環境
Unity2018.4.0f1

## Project構造

TankGameSample
* Game.scene (今回ベースとなるゲームシーン)
* Material (ベースとなる戦車の色などを保持させるデータが入ったフォルダ)
* Prefab (戦車のモデルとなるデータが入ったフォルダ)
* Script (戦車を動かしたり弾を撃つ処理を書くソースコードが入ったフォルダ)
* Extra (Game.sceneを拡張したサンプルを入れたフォルダ)
    * AdvancedCode (処理は同じだが中級者から上級者向けのコードの書き方サンプル) ※今回無い方が良い気がする、検討
    * AutoSpawn (敵戦車が自動的に生成されるようにしたサンプル)
    * NavMesh (Unityの機能であるNavMeshを使用して移動範囲を制限させたサンプル)
    * ScriptableObject (Unityの機能であるScriptableObjectでデータを保持させて扱うサンプル)
    * TransitionScene (タイトル画面からゲーム画面に移動するサンプル)

## その他リンク
// TODO: githubリンクとか?