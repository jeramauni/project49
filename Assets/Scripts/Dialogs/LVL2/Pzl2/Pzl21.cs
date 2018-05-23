using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pzl21 : MonoBehaviour {

	[SerializeField]
	private GameObject trapBox, SrT1, SrT3, SrT4, SrT6, Mch2, Mch5, cajaTxt, jugador;
	[SerializeField]
	GameManager gm;

	void Update() 
	{
		if (gm == null) {
			gm = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		}
	}
	private void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player")) 
		{

			jugador.GetComponent<CambiaPersonaje> ().allowed = false;
			cajaTxt.SetActive (true);
			SrT1.SetActive (true);
			Destroy (this.gameObject.GetComponent<Collider2D> ());
			if(!gm.personaje)
			{
				jugador.GetComponent<CambiaPersonaje> ().CdP ();
			}
			Invoke ("Dialogo41", 5);
		}

	}


	void Dialogo41 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (SrT1);
		Mch2.SetActive (true);
		Invoke ("Dialogo42", 4.5f);
	}

	void Dialogo42 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (Mch2);
		SrT3.SetActive (true);
		Invoke ("Dialogo43", 11);
	}

	void Dialogo43 () 
	{
		Destroy (SrT3);
		SrT4.SetActive (true);
		Invoke ("Dialogo44", 8);
	}

	void Dialogo44 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (SrT4);
		Mch5.SetActive (true);
		Invoke ("Dialogo45", 9);
	}

	void Dialogo45 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (Mch5);
		SrT6.SetActive (true);
		Invoke ("Terminate", 8);
	}

	void Terminate ()
	{
		cajaTxt.SetActive (false);
		trapBox.SetActive (false);
		Destroy (SrT6);
		jugador.GetComponent<CambiaPersonaje> ().allowed = true;
		Destroy (this.gameObject);
	}
}
