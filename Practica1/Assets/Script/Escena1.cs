using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escena1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Nombre Usuario" +PlayerPrefs.GetString("nombreUsuario"));
		Debug.Log ("Hola");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
