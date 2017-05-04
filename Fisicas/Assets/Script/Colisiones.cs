using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision miColision)
	{
		Debug.Log("Colision con " + miColision.gameObject.name);
	}

	void OnCollisionExit(Collision miColision)
	{
		Debug.Log("Salgo con " + miColision.gameObject.name);
	}

	void OnCollisionStay(Collision miColision)
	{
		Debug.Log("Estoy con " + miColision.gameObject.name);
	}

	void OnTriggerStay(Collider miColision)
	{
		Debug.Log("Atravieso " + miColision.gameObject.name);
	}
}
