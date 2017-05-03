using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject Esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			Debug.Log ("Pressed right click.");
			Esfera.transform.position = new Vector3(2, 2, 0);
		}
	}
}
