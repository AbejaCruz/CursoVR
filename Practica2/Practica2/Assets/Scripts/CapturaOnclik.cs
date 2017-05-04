using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CapturaOnclik : MonoBehaviour {

	public GameObject cubo;

	void Start () {
		GameObject.Find ("LabelTexto").GetComponent<Text> ().text = PlayerPrefs.GetString ("TextoEnviado");
	}
	
	void OnMouseDown()
	{
		cubo.GetComponent<girar> ().activarGiro ();
	}
}
