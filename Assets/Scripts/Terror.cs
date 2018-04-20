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

	void OnTriggerStay2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player")) {
			if (tipo == true) {
				gm.personaje = false;
				coll.gameObject.GetComponentInParent<CambiaPersonaje> ().CdP ();
			} else {
				gm.personaje = true;
				coll.gameObject.GetComponentInParent<CambiaPersonaje> ().CdP ();
			}
		}
	}
}
