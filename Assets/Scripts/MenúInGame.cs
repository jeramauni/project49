using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenúInGame : MonoBehaviour {
	
	public Transform sirT,machango;
	public GameManager gm;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Personaje ();
		}
	}
	public void Personaje ()
	{
		if (gm.personaje == true) {
			menú (sirT);
		} else {
			menú (machango);
		}
	}
	void menú ( Transform personaje)
	{
		if (personaje.gameObject.activeInHierarchy == false) {
			personaje.gameObject.SetActive (true);
		} else {
			sirT.gameObject.SetActive (false);
			machango.gameObject.SetActive (false);
		}
	}
}
