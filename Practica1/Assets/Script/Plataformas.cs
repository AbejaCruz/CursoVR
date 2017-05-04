using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		#if UNITY_EDITOR

		#endif

		#if UNITY_ANDROID
		this.gameObject.GetComponet<Renderer>().materiak.color=Color.green;
				#endif

		#if UNITY_STANDALONE_WIN
		this.gameObject.GetComponent<Renderer>().material.color=Color.blue;
		#endif
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
