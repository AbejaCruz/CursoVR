using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jerarquia : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject goPadre = GameObject.Find ("Padre");
		//cilindro.transform.parent = goPadre.transform;
		int numeroHijos = goPadre.transform.childCount;
		for (int i = 0; i < numeroHijos; i++) {
			Debug.LogError("");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
