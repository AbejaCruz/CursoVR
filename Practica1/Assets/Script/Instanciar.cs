using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour {
	public GameObject flecha;
	// Use this for initialization
	void Start () {
		//GameObject objetoInstanciado = GameObject.CreatePrimitive (PrimitiveType.Cube);
		//objetoInstanciado.transform.position = new Vector3 (3, 3, 3);
		//objetoInstanciado.transform.eulerAngles = new Vector3 (90, 180, 0);
		//GameObject.Instantiate(flecha,new Vector3(1,1,1),flecha.transform.rotation);
		//GameObject.Instantiate(flecha,new Vector3(3,3,3),flecha.transform.rotation);

		GameObject go1=GameObject.Find ("Bala");
		GameObject.Destroy (go1);
		GameObject[] misObjetos = GameObject.FindGameObjectsWithTag ("CursoTarde");
		foreach (GameObject go in misObjetos) {
		
			go.gameObject.GetComponent<Renderer> ().material.color = Color.black;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
