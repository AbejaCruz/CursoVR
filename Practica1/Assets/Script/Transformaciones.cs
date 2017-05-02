using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformaciones: MonoBehaviour {
	float velocidad=10.0f;
	float grados=50.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			this.gameObject.transform.Translate (Vector3.up * velocidad*Time.deltaTime);
			Debug.Log ("Subir");

	}
		if(Input.GetKey(KeyCode.S)){
			this.gameObject.transform.Translate (Vector3.up * velocidad*Time.deltaTime,Space.World);
			Debug.Log ("Subir");

		}
		if(Input.GetKey(KeyCode.DownArrow)){
			this.gameObject.transform.Translate (Vector3.down * velocidad*Time.deltaTime);

		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.gameObject.transform.Rotate(Vector3.left, grados*Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.gameObject.transform.Rotate(Vector3.right, grados*Time.deltaTime);
		}

		if (Input.GetKeyDown (KeyCode.K)) {
			GameObject.Find ("Manejador").GetComponent<Funcionalidad> ().llamada (0);
		}
}

}