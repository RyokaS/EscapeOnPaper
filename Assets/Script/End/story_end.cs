using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class story_end : MonoBehaviour {
	int s=0;
	public Text Story;

	// Use this for initialization
	void Start () {
		Story.text = " ";
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Return)) 
			s++;
		
	}

	void OnGUI () {
		switch (s) {
		case 0:
			Story.text = "アラン\r\n\r\n…じいちゃん、どういうこと";
		break;

		case 1:
			Story.text = "おじいちゃん\r\n\r\nおおアラン、無事で何よりだ";
		break;

		case 2:
			Story.text = "アラン\r\n\r\n知ってたのか";
		break;

		case 3:
			Story.text = "おじいちゃん\r\n\r\n知っていたも何も…昔、私もそれを開いたからな";
		break;

		case 4:
			Story.text = "アラン\r\n\r\nどうして俺にこれを渡したんだ?";
		break;

		case 5:
			Story.text = "おじいちゃん\r\n\r\nそんなの決まってるだろう?\r\n\r\n楽しい話は共有するべきだ。";
		break;

		case 6:
			Story.text = "おじいちゃん\r\n\r\nそれにこの本は開くたびに内容が変わる。";
		break;

		case 7:
			Story.text = "おじいちゃん\r\n\r\nそれで、お前は一体どんな目にあったんだ?";
		break;

		case 8:
			Story.text = "アラン\r\n\r\nああ、それが…";
		break;

		case 9:
			Story.text = "\r\n\r\n………………………";
		break;

		case 10:
			Story.text = "\r\n\r\n………………";
		break;

		case 11:
			Story.text = "\r\n\r\n………";
		break;

		case 12:
			SceneManager.LoadScene ("Start");
		break;
//		case :
//			story = "\r\n\r\n";
//		break;
		}
	}


}
	


// "\r\n\r\n"



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