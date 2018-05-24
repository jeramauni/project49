using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterludioDialogos : MonoBehaviour {


	[SerializeField]
	GameObject fondoTxt, jugador, dialogos10;
	[SerializeField]
	GameObject m1, t2, m3, t4, m5, t6, m7, t8, m9, t10, m11;
	[SerializeField]
	GameManager gm;

	// Use this for initialization
	void Start () 
	{
		//Inicializa el primer diálogo y desactiva los sucesores
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
		Invoke("dialog12", 2.5f);
	}

	void Update () 
	{
		if (gm == null) {
			gm = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		}
		gm.zona2 = true;
	}

	void dialog12 ()								//Métodos que administran la aparición de los textos
	{
		Destroy (m1.gameObject);
		t2.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog13", 6f);
	}

	void dialog13 ()
	{
		Destroy (t2.gameObject);
		m3.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog14", 6f);
	}

	void dialog14 ()
	{
		Destroy (m3.gameObject);
		t4.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog15", 6f);
	}

	void dialog15 ()
	{
		Destroy (t4.gameObject);
		m5.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog16", 10f);
	}

	void dialog16 ()
	{
		Destroy (m5.gameObject);
		t6.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog17", 8f);
	}

	void dialog17 ()
	{
		Destroy (t6.gameObject);
		m7.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog18", 6f);
	}

	void dialog18 ()
	{
		Destroy (m7.gameObject);
		t8.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog19", 10f);
	}

	void dialog19 ()
	{
		Destroy (t8.gameObject);
		m9.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog20", 10f);
	}

	void dialog20 ()
	{
		Destroy (m9.gameObject);
		t10.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog21", 6f);
	}

	void dialog21 ()
	{
		Destroy (t10.gameObject);
		m11.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("terminate", 3f);
	}
		

	void terminate ()						//Acaba con los elementos relacionados con el diálogo actual
	{
		fondoTxt.SetActive (false);
		jugador.GetComponent<CambiaPersonaje> ().allowed = true;
		Destroy (dialogos10.gameObject);
		Destroy (this.gameObject);
		SceneManager.LoadScene (3);
	}
}
