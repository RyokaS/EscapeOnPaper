using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling_floor : MonoBehaviour {
	GameObject[] floors = new GameObject[945];
	int count_time = 0;

	// Use this for initialization
	void Start () {
		
		for (int i=0; i<945; i+=5){
			string count1 = (i+1).ToString();
			string count2 = (i+2).ToString();
			string count3 = (i+3).ToString();
			string count4 = (i+4).ToString();
			string count5 = (i+5).ToString();
			floors [i] = GameObject.Find("WallCube (" + count1 + ")");
			floors [i+1] = GameObject.Find("WallCube (" + count2 + ")");
			floors [i+2] = GameObject.Find("WallCube (" + count3 + ")");
			floors [i+3] = GameObject.Find("WallCube (" + count4 + ")");
			floors [i+4] = GameObject.Find("WallCube (" + count5 + ")");
		}

	}

	// Update is called once per frame
	void Update () {

		count_time++;

		if (count_time % 10 == 0) {
			int i = count_time / 10;
			Destroy (floors[i]);
		}
	}
}
