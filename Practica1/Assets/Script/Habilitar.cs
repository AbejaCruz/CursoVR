using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habilitar : MonoBehaviour {

	public GameObject objetoHabilitar=null;

	// Use this for initialization
	void Start () {
		objetoHabilitar.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
