using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {
	public GameObject Objeto;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Pressed left click.");
			GameObject.Instantiate (Objeto, new Vector3 (2, 3, 3), Objeto.transform.rotation);

		}
	}
}
