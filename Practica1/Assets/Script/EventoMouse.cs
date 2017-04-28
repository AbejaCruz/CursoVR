using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		Debug.Log ("Mouse Clickeado");
		this.gameObject.transform.position = new Vector3 (1, 1, 1);
	}
	void OnMouseOver(){
		this.gameObject.GetComponent<Renderer> ().material.color = Color.black;

	}
	void OnMouseExit(){
		this.gameObject.GetComponent<Renderer> ().material.color = Color.white;
	}
}
