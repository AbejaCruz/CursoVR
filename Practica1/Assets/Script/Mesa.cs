using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesa : MonoBehaviour {
	public GameObject objetoInstanciado;
	// Use this for initialization
	void Start () {
		Debug.Log ("Hola");
		GameObject.Instantiate(objetoInstanciado,new Vector3(1,1,1),objetoInstanciado.transform.rotation);
		GameObject.Instantiate(objetoInstanciado,new Vector3(3,3,3),objetoInstanciado.transform.rotation);
		//GameObject go1=GameObject.Find ("Mesa");
		//	GameObject[] misObjetos = GameObject.FindGameObjectsWithTag ("CursoTarde");
		//foreach (GameObject go in misObjetos) {

		//	go.gameObject.GetComponent<Renderer> ().material.color = Color.black;
		//}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
