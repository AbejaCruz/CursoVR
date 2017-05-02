#pragma strict

function Start () {
	var goManejador = GameObject.Find("Manejador");
	var scriptF : Funcionalidad;
   scriptF=goManejador.GetComponent("Funcionalidad");
   scriptF.llamada(1);
}

function Update () {
	
}
