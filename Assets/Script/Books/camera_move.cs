using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move : MonoBehaviour {
	public GameObject Hero;
	public Camera camera;
	Vector3 pos_hero;
	Vector3 pos_cam;
	Vector3 pos_def;

	// Use this for initialization
	void Start () {
		pos_hero = Hero.transform.position;
		pos_cam = camera.transform.position;
		pos_def = pos_cam - pos_hero;
	}
	
	// Update is called once per frame
	void Update () {
		pos_hero = Hero.transform.position;
		pos_cam = pos_hero + pos_def;

		camera.transform.position = pos_cam; 

	}
}
