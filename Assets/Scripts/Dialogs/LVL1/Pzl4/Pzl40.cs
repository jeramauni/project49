using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pzl40 : MonoBehaviour {

	[SerializeField]
	private GameObject trapBox, SrT1, SrT3, SrT5, Mch2, Mch4, Mch6, cajaTxt, jugador;
	[SerializeField]
	GameManager gm;

	private void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player")) 
		{
			if(!gm.personaje)
			{
				jugador.GetComponent<CambiaPersonaje> ().CdP ();
			}
			jugador.GetComponent<CambiaPersonaje> ().allowed = false;
			cajaTxt.SetActive (true);
			SrT1.SetActive (true);
			Destroy (this.gameObject.GetComponent<Collider2D> ());
			Invoke ("Dialogo41", 3);
		}

	}


	void Dialogo41 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (SrT1);
		Mch2.SetActive (true);
		Invoke ("Dialogo42", 3);
	}

	void Dialogo42 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (Mch2);
		SrT3.SetActive (true);
		Invoke ("Dialogo43", 6);
	}

	void Dialogo43 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (SrT3);
		Mch4.SetActive (true);
		Invoke ("Dialogo44", 3);
	}

	void Dialogo44 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (Mch4);
		SrT5.SetActive (true);
		Invoke ("Dialogo45", 3);
	}

	void Dialogo45 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (SrT5);
		Mch6.SetActive (true);
		Invoke ("Terminate", 3);
	}

	void Terminate ()
	{
		cajaTxt.SetActive (false);
		trapBox.SetActive (false);
		Destroy (Mch6);
		jugador.GetComponent<CambiaPersonaje> ().allowed = true;
		Destroy (this.gameObject);
	}
}
