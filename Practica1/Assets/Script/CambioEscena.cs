﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString ("nombreUsuario", "Pablo");


	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			SceneManager.LoadScene ("Clase6.1");
		
		}
		
	}
}
