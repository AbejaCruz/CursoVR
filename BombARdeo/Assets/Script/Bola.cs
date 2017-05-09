using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left*10.0f, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (this);
		
	}
}
