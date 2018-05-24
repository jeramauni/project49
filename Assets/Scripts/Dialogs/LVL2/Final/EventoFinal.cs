using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoFinal : MonoBehaviour {

	[SerializeField]
	GameObject fondoTxt, jugador, barrier1, dialogos10;
	[SerializeField]
	GameObject t1, m2, m21, t3, m4, t5, m6, m61, m7, m71, camara, machangoD, machangoM, srTabaibaD, srTabaibaS;
	[SerializeField]
	GameManager gm;

	void Update (){
		if (gm == null) {
			gm = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		}
	}

	void OnTriggerEnter2D (Collider2D coll) 
	{
		if(coll.gameObject.CompareTag("Player"))
		{
		fondoTxt.SetActive (true);
		barrier1.SetActive (true);
		camara.SetActive (true);
		Destroy(GameObject.Find("Camara Nivel 1"));
			if(!gm.personaje)
			{
				jugador.GetComponent<CambiaPersonaje> ().CdP ();
			}
		t1.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().allowed = false; 
		m2.SetActive (false);
		t3.SetActive (false);
		m4.SetActive (false);
		t5.SetActive (false);
		Invoke ("dialog12", 3f);
		}
	}


	void dialog12 ()
	{
		Destroy (t1.gameObject);
		m2.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog121", 8f);
	}
	void dialog121 ()
	{
		Destroy (m2.gameObject);
		m21.SetActive (true);
		Invoke ("dialog13", 8f);
	}
	void dialog13 ()
	{
		Destroy (m21.gameObject);
		t3.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog14", 7f);
	}

	void dialog14 ()
	{
		Destroy (t3.gameObject);
		m4.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog15", 6f);
	}

	void dialog15 ()
	{
		Destroy (m4.gameObject);
		t5.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog16", 6f);
	}

	void dialog16 ()
	{
		machangoD.SetActive (false);
		machangoM.SetActive (true);
		Destroy (t5.gameObject);
		m6.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().CdP ();
		Invoke ("dialog161", 8f);
	}

	void dialog161 ()
	{
		Destroy (m6.gameObject);
		m61.SetActive (true);
		Invoke ("dialog17", 8f);
	}

	void dialog17 ()
	{
		machangoM.SetActive (false);
		machangoD.SetActive (true);
		srTabaibaD.SetActive (false);
		srTabaibaS.SetActive (true);
		Destroy (m61.gameObject);
		m7.SetActive (true);
		Invoke ("dialog171", 8f);
	}

	void dialog171 ()
	{
		Destroy (m7.gameObject);
		m71.SetActive (true);
		Invoke ("terminate", 5f);
	}

	void terminate ()						//Acaba con los elementos relacionados con el diálogo actual
	{
		fondoTxt.SetActive (false);
		jugador.GetComponent<CambiaPersonaje> ().allowed = true;
		Destroy (dialogos10.gameObject);
		Destroy (this.gameObject);
	}
}
