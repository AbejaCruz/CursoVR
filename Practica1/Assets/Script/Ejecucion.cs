using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejecucion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("start");
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Update");
		if (Input.GetKey("up"))
			Debug.Log("up arrow key is held down");

		if (Input.GetKey("down"))
			Debug.Log("down arrow key is held down");
		if(Input.GetButtonDown("Fire1")){
			Debug.Log("Disparo");
		}
	
	}

	void Awake(){
	
		Debug.Log("Awake");
	}
}
