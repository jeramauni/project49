using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterludioDialogos : MonoBehaviour {


	[SerializeField]
	GameObject fondoTxt, jugador, dialogos10;
	[SerializeField]
	GameObject m1, t2, m3, t4, m5, t6, m7, t8, m9, t10, m11;
	int numDialogos = 0;
	private bool stop;

	// Use this for initialization
	void Start () 
	{
		stop = false;				//Inicializa el primer diálogo y desactiva los sucesores
		fondoTxt.SetActive (true);
		m1.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().allowed = false; //No permite cambiar de personaje
		t2.SetActive (false);
		m3.SetActive (false);
		t4.SetActive (false);
		m5.SetActive (false);
		t6.SetActive (false);
		m7.SetActive (false);
		t8.SetActive (false);
		m9.SetActive (false);
		t10.SetActive (false);
		m11.SetActive (false);
		Invoke("dialog11", 2.5f);
	}

	void dialog11 ()
	{
		stop = true;
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
				Invoke ("dialog16", 0.5f);
				numDialogos++;
			}
			break;
		case 5:
			if (Input.GetKeyDown (KeyCode.Z)) {
				Invoke ("dialog17", 0.5f);
				numDialogos++;
			}
			break;
		case 6:
			if (Input.GetKeyDown (KeyCode.Z)) {
				Invoke ("dialog18", 0.5f);
				numDialogos++;
			}
			break;
		case 7:
			if (Input.GetKeyDown (KeyCode.Z)) {
				Invoke ("dialog19", 0.5f);
				numDialogos++;
			}
			break;
		case 8:
			if (Input.GetKeyDown (KeyCode.Z)) {
				Invoke ("dialog20", 0.5f);
				numDialogos++;
			}
			break;
		case 9:
			if (Input.GetKeyDown (KeyCode.Z)) {
				Invoke ("dialog21", 0.5f);
				numDialogos++;
			}
			break;
		case 10:
			if (Input.GetKeyDown (KeyCode.Z)) {
				Invoke ("terminate", 0.5f);
			}
			break;
		default:
			break;
		}
	}

	void dialog12 ()								//Métodos que administran la aparición de los textos
	{
		Destroy (m1.gameObject);
		t2.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void dialog13 ()
	{
		Destroy (t2.gameObject);
		m3.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void dialog14 ()
	{
		Destroy (m3.gameObject);
		t4.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void dialog15 ()
	{
		Destroy (t4.gameObject);
		m5.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void dialog16 ()
	{
		Destroy (m5.gameObject);
		t6.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void dialog17 ()
	{
		Destroy (t6.gameObject);
		m7.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void dialog18 ()
	{
		Destroy (m7.gameObject);
		t8.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void dialog19 ()
	{
		Destroy (t8.gameObject);
		m9.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void dialog20 ()
	{
		Destroy (m9.gameObject);
		t10.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}

	void dialog21 ()
	{
		Destroy (t10.gameObject);
		m11.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
	}
		

	void terminate ()						//Acaba con los elementos relacionados con el diálogo actual
	{
		fondoTxt.SetActive (false);
		jugador.GetComponent<CambiaPersonaje> ().allowed = true;
		Destroy (dialogos10.gameObject);
		Destroy (this.gameObject);
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
}
