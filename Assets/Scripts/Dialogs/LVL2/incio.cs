using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incio : MonoBehaviour {

	[SerializeField]
	GameObject fondoTxt, jugador, barrier1, dialogos10;
	[SerializeField]
	GameObject t1, m2, t3, t4, m5;
	int numDialogos = 0;

	void Start () 
	{				//Inicializa el primer diálogo y desactiva los sucesores
		fondoTxt.SetActive (true);
		t1.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().allowed = false; //No permite cambiar de personaje
		m2.SetActive (false);
		t3.SetActive (false);
		t4.SetActive (false);
		m5.SetActive (false);
	}


	void Update ()
	{
		switch (numDialogos) {
		case 0:
			if (Input.GetKeyDown (KeyCode.Z)) {
				Invoke ("dialog12", 0.5f);
				numDialogos++;
			}
			break;
		case 1:
			if (Input.GetKeyDown (KeyCode.Z)) {
				Invoke ("dialog13", 0.5f);
				numDialogos++;
			}
			break;
		case 2:
			if (Input.GetKeyDown (KeyCode.Z)) {
				Invoke ("dialog14", 0.5f);
				numDialogos++;
			}
			break;
		case 3:
			if (Input.GetKeyDown (KeyCode.Z)) {
				Invoke ("dialog15", 0.5f);
				numDialogos++;
			}
			break;
		case 4:
			if (Input.GetKeyDown (KeyCode.Z)) {
				Invoke ("terminate", 0.5f);
				numDialogos++;
			}
			break;
		}
	}

	void dialog12 ()								//Métodos que administran la aparición de los textos
	{
		Destroy (t1.gameObject);
		m2.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void dialog13 ()
	{
		Destroy (m2.gameObject);
		t3.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void dialog14 ()
	{
		Destroy (t3.gameObject);
		t4.SetActive (true);
	}

	void dialog15 ()
	{
		Destroy (t4.gameObject);
		m5.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void terminate ()						//Acaba con los elementos relacionados con el diálogo actual
	{
		fondoTxt.SetActive (false);
		jugador.GetComponent<CambiaPersonaje> ().allowed = true;
		Destroy (dialogos10.gameObject);
		Destroy (this.gameObject);
	}
}
