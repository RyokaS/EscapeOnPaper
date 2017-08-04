using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hit : MonoBehaviour {
	public GameObject Door;
//	public Collision StickPerson_1;
//	GameObject fallf;

	// Use this for initialization
	void Start () {
//		Door = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(){
//		Destroy (Door);
		SceneManager.LoadScene("End");

	}
}
