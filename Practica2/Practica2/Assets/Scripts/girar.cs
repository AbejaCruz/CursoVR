using UnityEngine;
using System.Collections;

public class girar : MonoBehaviour {

	bool girando = false;

	void Update () {
		if (girando == true)
			transform.Rotate (Vector3.right * 30 * Time.deltaTime);

		if (Input.GetKeyDown ("p"))
			activarGiro ();
	}

	public void activarGiro()
	{
		if (!girando)
			girando = true;
		else
			girando = false;
	}
}
