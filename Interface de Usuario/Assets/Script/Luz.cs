using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Luz : MonoBehaviour {
	public GameObject miLuz;
	public Text miTexto;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EnciendoLuz(bool enciendo)
	{
		miLuz.SetActive (enciendo);
	}
	public void PongoRojo(bool encendido){
		miLuz.GetComponent<Light> ().color = Color.red;
	}
	public void PongoVerde(bool encendido){
		miLuz.GetComponent<Light> ().color = Color.green;
	}
	public void PongoAzul(bool encendido){
		miLuz.GetComponent<Light> ().color = Color.blue;
	}
	public void PongoIntensidad(float intensidad){
	
		miLuz.GetComponent<Light> ().intensity = intensidad;

	}

	public void LuzEncendidad(){
		EnciendoLuz (true);
	}

	public void LuzApagada(){
		EnciendoLuz (false);
	}

	public void CambioTexto(string texto){
		miTexto.text = texto;
	}

}
