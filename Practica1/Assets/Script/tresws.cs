using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tresws : MonoBehaviour {
	private string url="https://image.freepik.com/free-icon/macos-platform_318-33076.jpg";
	// Use this for initialization
	IEnumerator Start() {
		WWW miTresws = new WWW (url);
		yield return miTresws;
		this.gameObject.GetComponent<Renderer> ().material.mainTexture = miTresws.texture;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
