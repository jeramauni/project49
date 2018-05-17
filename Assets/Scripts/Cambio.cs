using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio : MonoBehaviour {

	public GameObject primer;
	bool activador = false;

		void OnTriggerEnter2D (Collider2D coll)
		{
			if (coll.gameObject.CompareTag ("Player")) 
			{
			primer.SetActive (true);
			activador = true;
			}
		if (activador == true) {
			gameObject.SetActive (false);
		}
		}

}
