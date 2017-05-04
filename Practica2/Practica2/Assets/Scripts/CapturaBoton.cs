using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CapturaBoton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ponerTexto()
	{
		Debug.Log (GameObject.Find ("CampoEntrada").GetComponent<InputField> ().text);
		GameObject.Find ("CampoTexto").GetComponent<Text> ().text = GameObject.Find ("CampoEntrada").GetComponent<InputField> ().text;
	}



	public void cambiarEscena()
	{
		Debug.Log (GameObject.Find ("CampoEntrada").GetComponent<InputField> ().text);
		PlayerPrefs.SetString("TextoEnviado",GameObject.Find ("CampoEntrada").GetComponent<InputField> ().text);
		SceneManager.LoadScene ("scene02");
	}
}
