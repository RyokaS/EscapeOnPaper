using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour {
	public GameObject Hero;
	Vector3 pos;
	float pos_first;
	Quaternion rot;

	Animator motion;

	float posx;
	float posy;
	float posz;

//	bool jumping = false;
//
//	float i = 0f;
//	float j = 0f;

	// Use this for initialization
	void Start () {

		motion = GetComponent (typeof(Animator)) as Animator;
		pos_first = Hero.transform.position.y;
		pos = Hero.transform.position;
		posx = pos.x;
		posx = pos_first;
		posz = pos.z;
		rot = Hero.transform.rotation;

	}

	// Update is called once per frame
	void Update () {
		pos = Hero.transform.position;
		posx = pos.x;
		posy = pos.y;
		posz = pos.z;
		Hero.transform.rotation = rot;
		Debug.Log (rot);

		if (Input.GetKeyDown (KeyCode.C)) {
			motion.Play ("jump");
			Hero.transform.position = new Vector3 (posx, posy, posz);
//			jumping = true;
//			if (0f<i && i<400f) {
//				Debug.Log (i);
////				posy += i * 0.0005f;
//				Hero.transform.position = new Vector3 (posx, posy, posz);
//			} else if (400f < i && i < 1000f) {
//				Debug.Log (i);
//				posy += i * 0.1f;
//				Hero.transform.position = new Vector3 (posx, posy, posz);
//			} else {
//				Debug.Log (i);
//				jumping = false;
//			}
		} else {
			posy = pos_first;


			if (Input.GetKey (KeyCode.UpArrow)) {
				rot.y = 0f;
				if (Input.GetKey (KeyCode.X)) {
					posz += 0.056f;
					motion.Play ("run");
				} else {
					posx += 0f;
					posz += 0.028f;
					motion.Play ("walk");
				}
				Hero.transform.position = new Vector3 (posx, posy, posz);
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				rot.y = 180f;
				if (Input.GetKey (KeyCode.X)) {
					posz -= 0.056f;
					motion.Play ("run");
				} else {
					posx += 0f;
					posz-= 0.028f;
					motion.Play ("walk");
				}
				Hero.transform.position = new Vector3 (posx, posy, posz);
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				rot.y = 1f;
				if (Input.GetKey (KeyCode.X)) {
					posx += 0.056f;
					motion.Play ("run");
				} else {
					posx+= 0.028f;
					posz += 0f;
					motion.Play ("walk");
				}
				Hero.transform.position = new Vector3 (posx, posy, posz);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				rot.y = -1f;
				if (Input.GetKey (KeyCode.X)) {
					posx -= 0.056f;
					motion.Play ("run");
				} else {
					posx-= 0.028f;
					posz += 0f;
					motion.Play ("walk");
				}
				Hero.transform.position = new Vector3 (posx, posy, posz);
			}
		}

		
	}
}
