using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class story_start : MonoBehaviour {
	public Text Story;
	int s=0;
	public GameObject textf;
	public GameObject title;
	bool start = false;

	// Use this for initialization
	void Start () {
		Story = GetComponentInChildren<Text> ();
		Story.text = " ";
		textf = GameObject.Find ("TextField");
		textf.SetActive (true);
		title.SetActive (true);

	}

	// Update is called once per frame
	void Update () {
		if (start) {
			if (Input.GetKeyDown (KeyCode.Return)) {
				s++;
			}
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			title.SetActive (false);
			start = true;
			s = 1;
		}
	}

	void OnGUI () {
		switch (s) {
		//		case 0:
		//			Story.text = " ";
		//			break;
		case 1:
			Story.text = "おじいちゃん\r\n\r\nアラン、そろそろお前にこれをやろう。\r\nお前の父さんには少し合わなかったみたいだが…お前なら気に入ってくれるだろう。";
			break;
		case 2:
			Story.text = "おじいちゃん\r\n\r\nこの本は私の一番のお気に入りだ";
			break;
		case 3:
			Story.text = "アラン\r\n\r\nどんな話なの?";
			break;
		case 4:
			Story.text = "おじいちゃん\r\n\r\nまぁ読めばわかる。";
			break;
		case 5:
			Story.text = "アラン\r\n\r\n…どういうこと?";
			break;
		case 6:
			Story.text = "おじいちゃん\r\n\r\n私がこの本を開いたときは…そうだな\r\n\r\nたしか…ああ、そうだ。壁が崩れてきた…";
			break;
		case 7:
			Story.text = "アラン\r\n\r\nは?";
			break;
		case 8:
			Story.text = "おじいちゃん\r\n\r\nなぁに、物語の中では何でも起こるという話だ。";
			break;
		case 9:
			Story.text = "アラン\r\n\r\nじいちゃん、本ありがとう。もう用は終わり?";
			break;
		case 10:
			Story.text = "おじいちゃん\r\n\r\nそう焦るな。この本を開いて…\r\nそうだな、またお前に会えたなら…その時は、話を聞かせてくれ。";
			break;
		case 11:
			Story.text = "\r\n\r\n......";
			break;		
		case 12:
			Story.text = "\r\n\r\n......\r\n............";
			break;
		case 13:
			// ここでAsset変化させたい
			Story.text = "アラン\r\n\r\nあの時のじいちゃんは、変だった";
			break;
		case 14:
			Story.text = "アラン\r\n\r\nそれに、俺にこの本を渡したくない様にも見えた";
			break;
		case 15:
			Story.text = "アラン\r\n\r\nだから余計に気になって、部屋を出てすぐに本を開いたんだ";
			break;
		case 16:
			Story.text = " ";
			textf.SetActive (false);
			SceneManager.LoadScene("Books");
			break;
//		case 17:
//			Story.text = "アラン\r\n\r\n";
//			break;
//		case 18:
//			Story.text = "";
//			break;
//		case 19:
//			Story.text = "";
//			break;
//		case 20:
//			Story.text = "";
//			break;
		}
	}


}


//ホワイトアウト
//一人称視点
//
//「………何だ、これ」
//「ここ何処だよ…」
//
//カメラ一周
//for(int i=0; i<360; i++){
//	transform.rotate.y++;
//}
//
//「どういうことだ……?」
//
//カメラ、後ろ振り返る
//はじのほうが崩れ始めてる
//
//「何だあれ…」
//
//どんどん崩れる
//
//「何かヤバくないか?」
//「とりあえず逃げよう!!」
//
//視点変化
//Sprite
//キーの説明
//
//「十字キーで移動
//Cキーでジャンプ
//もっと早く動きたい時はXキーを十字キーと一緒に押してくれ」
//
//
//半分くらいまで走る
//
//「ヤバい、このままじゃアレに追いつかれる!!」(autoで次の会話に)
//「先の方に通路が見えた!! まずそこまで行こう!!!」(autoで消える)
//
//
//通路に着く
//
//ーstage1 CLEARー
//ホワイトアウト
//シーン移動
//
//
//「一体何なんだよ…
//じいちゃんが言ってた気をつけろってこういうことだったのか…?」
//
//通路より前の部屋のキューブが全部消える
//
//
//「……進むしかないってことか」
//
//視点変化
//
//先が浮島になってるステージ
//また足場が消え始める
//
//浮島に乗ってる時間が10秒を超えると浮島が落ちる
//(色変化 だんだん赤に)
//
//
//最後の通路が見えるところに到達
//通路に入る
//
//
//ーstage2 CLEARー
//ホワイトアウト
//シーン移動
//
//「…いつまで続くんだよ、これ」
//
//目の前には壁と足場
//ジャンプして登っていく
//
//崖の上に到達
//
//ーAll stage CLEARー
//ホワイトアウト
//
//
//「…じいちゃん、どういうことだよ」
//「おおアラン、無事で何よりだ」
//「知ってたのか」
//「知っていたも何も…昔、私もそれを開いたからな」
//「どうして俺にこれを渡したんだ?」
//「そんなの決まってるだろう?
//楽しい話は共有するべきだ。
//それにこの本は開くたびに内容が変わる。」
//「それで、お前は一体どんな目にあったんだ?」
//「ああ、それが…」
//
//
//ブラックアウト
//スタート画面に戻る