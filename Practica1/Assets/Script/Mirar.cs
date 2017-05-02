using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirar : MonoBehaviour {
	public Transform objetivo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.LookAt (objetivo);
	}
}
