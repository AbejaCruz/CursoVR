using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTarde : MonoBehaviour {
	public int numeroVeces=0;
	public GameObject objeto=null;
	// Use this for initialization
	void Start () {
		Debug.Log ("Hello World");
		Debug.Log("Numero Veces: "+numeroVeces );
		Debug.Log ("Mi Nombre: " + this.gameObject.name);
		Debug.Log ("Nombre Objeto: "+objeto.name);

		Vector3 posicion=  new Vector3();
		posicion = this.gameObject.transform.position;
		//Mostrar Los Transform de cada Objeto
		Debug.Log("Mi posicion: "+posicion);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
