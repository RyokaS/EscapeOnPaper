using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	Animator animation;

	// Use this for initialization
	void Start () {
		animation = GetComponent (typeof(Animator)) as Animator;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.C)) {
			animation.SetBool ("jump",true);
		}
	}
}
