using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CAMBIA EL PERSONAJE QUE CONTROLA EL JUGADOR MIENTRAS ESTE PERMANESCA EN UN AREA DETERMINADA

public class Terror : MonoBehaviour {

	public GameManager gm;
	public bool tipo;
	/*
	Muñeco de Madera = true
	"Flor de Estrendar" = false
	 */

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player")) {
			if (gm.personaje == tipo) {
				coll.gameObject.GetComponentInParent<CambiaPersonaje> ().CdP ();
			}
			coll.gameObject.GetComponentInParent<CambiaPersonaje> ().enabled = false;
		}
	}
	void OnTriggerExit2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player")) {
			coll.gameObject.GetComponentInParent<CambiaPersonaje> ().enabled = true;
		}
	}
}
