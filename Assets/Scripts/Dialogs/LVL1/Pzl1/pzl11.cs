using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pzl11 : MonoBehaviour {
	
	[SerializeField]
	GameObject zbutton, fondoTxt, jugador, barrier1, dialogos10;
	[SerializeField]
	GameObject t1, m2, t3, t4, m5;
	 
	private bool stop;

	// Use this for initialization
	void Start () 
	{
		stop = false;				//Inicializa el primer diálogo y desactiva los sucesores
		fondoTxt.SetActive (true);
		t1.SetActive (true);
		zbutton.SetActive (false);
		jugador.GetComponent<CambiaPersonaje> ().allowed = false; //No permite cambiar de personaje
		m2.SetActive (false);
		t3.SetActive (false);
		t4.SetActive (false);
		m5.SetActive (false);
		Invoke("dialog11", 2.5f);
	}

	void dialog11 ()
	{
		zbutton.SetActive (true);
		stop = true;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Z) && stop) 	//A partir del momento adecuado si se pulsa z
		{											//desaparece el txt1 y la barrera invisible
			Destroy (t1.gameObject);
			Destroy (zbutton.gameObject);
			jugador.GetComponent<CambiaPersonaje> ().CdP ();
			Invoke ("dialog12", 0.75f);
		}
	}

	void dialog12 ()								//Métodos que administran la aparición de los textos
	{
		stop = false;
		m2.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().allowed = false;
		Invoke ("dialog13", 3);
	}

	void dialog13 ()
	{
		Destroy (m2.gameObject);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		t3.SetActive (true);
		Invoke ("dialog14", 6);
	}

	void dialog14 ()
	{
		Destroy (t3.gameObject);
		t4.SetActive (true);
		Invoke ("dialog15", 6.5f);
	}

	void dialog15 ()
	{
		Destroy (t4.gameObject);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		m5.SetActive (true);
		Invoke ("terminate", 6f);
	}

	void terminate ()						//Acaba con los elementos relacionados con el diálogo actual
	{
		fondoTxt.SetActive (false);
		jugador.GetComponent<CambiaPersonaje> ().allowed = true;
		Destroy (dialogos10.gameObject);
		Destroy (this.gameObject);
	}
}
