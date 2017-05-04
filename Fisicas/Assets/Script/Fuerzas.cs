using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerzas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//this.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.right * 20f, ForceMode.Impulse);
		//this.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.right * 20f, ForceMode.VelocityChange);


	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Tiempo Update:" + Time.deltaTime);
	}
	void FixedUpdate(){
		//this.gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.right * 20f, ForceMode.Force);
		Debug.Log ("Tiempo Fixeupdate:" + Time.deltaTime);
	}
}
