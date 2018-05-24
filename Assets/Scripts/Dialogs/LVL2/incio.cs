using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incio : MonoBehaviour {

	[SerializeField]
	GameObject fondoTxt, jugador, barrier1, dialogos10;
	[SerializeField]
	GameObject t1, m2, t3, t4, m5;
	[SerializeField]
	GameManager gm;

	void Start () 
	{				//Inicializa el primer diálogo y desactiva los sucesores
		fondoTxt.SetActive (true);
		t1.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().allowed = false; //No permite cambiar de personaje
		m2.SetActive (false);
		t3.SetActive (false);
		t4.SetActive (false);
		m5.SetActive (false);
		Invoke ("dialog12", 5f);
	}
		
	void Update () 
	{
		if (gm == null) {
			gm = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		}
		gm.zona3 = true;
	}

	void dialog12 ()								//Métodos que administran la aparición de los textos
	{
		Destroy (t1.gameObject);
		m2.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog13", 3f);
	}

	void dialog13 ()
	{
		Destroy (m2.gameObject);
		t3.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog14", 6f);
	}

	void dialog14 ()
	{
		Destroy (t3.gameObject);
		t4.SetActive (true);
		Invoke ("dialog15", 6f);
	}

	void dialog15 ()
	{
		Destroy (t4.gameObject);
		m5.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("terminate", 3f);
	}

	void terminate ()						//Acaba con los elementos relacionados con el diálogo actual
	{
		fondoTxt.SetActive (false);
		jugador.GetComponent<CambiaPersonaje> ().allowed = true;
		Destroy (dialogos10.gameObject);
		Destroy (this.gameObject);
	}
}
