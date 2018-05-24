using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pzl31 : MonoBehaviour {

	[SerializeField]
	private GameObject trapBox, SrT1, SrT3, SrT5, SrT7, Mch2, Mch4, Mch6,cajaTxt, jugador;
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
			Invoke ("Dialogo41", 3);
		}

	}


	void Dialogo41 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (SrT1);
		Mch2.SetActive (true);
		Invoke ("Dialogo42", 5);
	}

	void Dialogo42 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (Mch2);
		SrT3.SetActive (true);
		Invoke ("Dialogo43", 4);
	}

	void Dialogo43 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (SrT3);
		Mch4.SetActive (true);
		Invoke ("Dialogo44", 10);
	}

	void Dialogo44 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (Mch4);
		SrT5.SetActive (true);
		Invoke ("Dialogo45", 4);
	}

	void Dialogo45 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (SrT5);
		Mch6.SetActive (true);
		Invoke ("Dialogo46", 4);
	}

	void Dialogo46 () 
	{
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Destroy (Mch6);
		SrT7.SetActive (true);
		Invoke ("Terminate", 5);
	}

	void Terminate ()
	{
		cajaTxt.SetActive (false);
		trapBox.SetActive (false);
		Destroy (SrT7);
		jugador.GetComponent<CambiaPersonaje> ().allowed = true;
		Destroy (this.gameObject);
	}
}
