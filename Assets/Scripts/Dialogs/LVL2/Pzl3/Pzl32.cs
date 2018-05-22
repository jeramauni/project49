using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pzl32 : MonoBehaviour {

	[SerializeField]
	private GameObject trapBox, SrT2, Mch1, Mch3, cajaTxt, jugador, flor;
	[SerializeField]
	GameManager gm;

	bool control = true;

	void Update () 
	{
		if (gm == null) {
			gm = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		}
		if (flor == null && control == true) {
			if(gm.personaje)
			{
				jugador.GetComponent<CambiaPersonaje> ().CdP ();
			}
			jugador.GetComponent<CambiaPersonaje> ().allowed = false;
			trapBox.SetActive (true);
			cajaTxt.SetActive (true);
			Mch1.SetActive (true);
			Invoke ("Dialogo41", 4);
			control = false;
		}
	}

	void Dialogo41 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (Mch1);
		SrT2.SetActive (true);
		Invoke ("Dialogo42", 4);
	}

	void Dialogo42 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (SrT2);
		Mch3.SetActive (true);
		Invoke ("Terminate", 2);
	}

	void Terminate ()
	{
		cajaTxt.SetActive (false);
		trapBox.SetActive (false);
		Destroy (Mch3);
		jugador.GetComponent<CambiaPersonaje> ().allowed = true;
		Destroy (this.gameObject);
	}
}
