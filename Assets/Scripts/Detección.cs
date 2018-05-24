using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script simple para dar información sobre la colisión de un objeto o collider

public class Detección : MonoBehaviour {

	public bool dentro = false, personaje = false, piedra = false;
	public GameObject piedraG;
	void OnCollisionStay2D(Collision2D coll)
	{
		dentro = true;
		if (coll.gameObject.CompareTag ("Player")) {
			personaje = true;
		}
		if (coll.gameObject.CompareTag ("caja")) {
			piedra = true;
			piedraG = coll.gameObject;
		}
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		dentro = false;
		if (coll.gameObject.CompareTag ("Player")) {
			personaje = false;
		}
		if (coll.gameObject.CompareTag ("caja")) {
			piedra = false;
		}
	}
}
