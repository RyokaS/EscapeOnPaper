using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class story : MonoBehaviour {
	public Text Story;
	int s=0;
	public GameObject textf;
	public GameObject fallf;
	public GameObject tcam;
	public GameObject pcam;
//	float rotate = 0;

	// Use this for initialization
	void Start () {
		Story = GetComponentInChildren<Text> ();
		Story.text = " ";
		textf = GameObject.Find ("TextField");
		fallf = GameObject.Find ("Falling");
//		tcam = GameObject.Find ("Camera");
//		pcam = GameObject.Find ("StickPerson_1/Camera");
//		textf.SetActive (true);
		fallf.SetActive (false);
//		tcam.SetActive (true);
		pcam.SetActive (false);
//		rotate = pcam.transform.rotation.y;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Return)) {
			s++;
		}
	}

	void OnGUI () {
		switch (s) {
//		case 0:
//			Story.text = " ";
//			break;
		case 1:
			Story.text = "アラン\r\n\r\n………何だ、これ";
			break;
		case 2:
			Story.text = "アラン\r\n\r\nここ何処だよ…";
			break;
		case 3:
			Story.text = "アラン\r\n\r\nどういうことだ……?";
			break;
//		case 4:
//			Story.text = " ";
//			textf.SetActive (false);
//			tcam.SetActive (false);
//			pcam.SetActive (true);
//			for (float i = 0f; i < 360f; i++) {
//				Debug.Log (i);
//				pcam.transform.Rotate(new Vector3(0 , i*500f, 0));
////				if (Input.GetKeyDown (KeyCode.Return)) {
////					pcam.transform.Rotate(new Vector3(0 , rotate, 0));
////				}
//			}
//			break;
		case 5:
			Story.text = "アラン\r\n\r\n何だあれ…";
			break;

		case 6:
			Story.text = "アラン\r\n\r\n何かヤバくないか?";
			break;

		case 7:
			Story.text = "アラン\r\n\r\n床が落ちてく…?\r\n\r\nとりあえず逃げよう!!";
			break;

		case 8:
			Story.text = "キーの説明\r\n\r\n十字キーで移動\r\n\r\nCキーでジャンプ\r\n\r\nもっと早く動きたい時はXキーを十字キーと一緒に押してくれ";
			break;

		case 9:
			Story.text = "";
			textf.SetActive (false);
			fallf.SetActive (true);
			tcam.SetActive (false);
			pcam.SetActive (true);
			break;

//		case :
//			Story.text = "";
//			break;
		}
	}


}



//
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