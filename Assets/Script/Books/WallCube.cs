using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCube : MonoBehaviour {

	public GameObject wall;
	public GameObject clearwall;
	bool walls = true;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (walls){
			for (float i = 0; i < 11; i++) {
				for (float j = 0; j < 11; j++) {
					Vector3 post_floor = new Vector3 (-6f + j * 0.5f, 0f, -0.5f * i);
//					Vector3 post_back = new Vector3 (-6f + j * 0.5f, 0.5f - 0.5f * i, 24.5f);
//					Vector3 post_left = new Vector3 (-6.5f, 24.5f - 0.5f * i, -24.5f + 0.5f * j);
//					Vector3 post_flont = new Vector3 (-6f + j * 0.5f, 0.5f - 0.5f * i, -25f);
//					Vector3 post_right = new Vector3 (19f, 24.5f - 0.5f * i, -24.5f + 0.5f * j);
					Vector3 post_back = new Vector3 (-6f+j*0.5f, 5f-0.5f*i, 0.5f);
					Vector3 post_left = new Vector3 (-6.5f, 5f-0.5f*i, -4.5f+0.5f*j);
					Vector3 post_flont = new Vector3 (-6f+j*0.5f, 5f-0.5f*i, -5f);
					Vector3 post_right = new Vector3 (-1f, 5f-0.5f*i, -4.5f+0.5f*j);

					Instantiate (wall, post_floor, Quaternion.identity);
					Instantiate (wall, post_back, Quaternion.identity);
					Instantiate (wall, post_left, Quaternion.identity);
					Instantiate (clearwall, post_flont, Quaternion.identity);
					Instantiate (clearwall, post_right, Quaternion.identity);
				}
			}
		walls = false;
		}
		
	}
}
