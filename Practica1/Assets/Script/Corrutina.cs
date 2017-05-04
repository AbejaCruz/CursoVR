using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutina : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
		Debug.Log ("Inicio Ejecucion");
		Debug.Log (Time.time);
		yield return StartCoroutine(miFuncion(3));
		Debug.Log("fin Ejecucion");
		Debug.Log(Time.time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator miFuncion(float tiempoEspera)
	{
		Debug.Log("Inicion Mi funcuion");
		yield return new WaitForSeconds(tiempoEspera);
		Debug.Log("fin miFuncion");
	}
}
