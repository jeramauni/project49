using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour {

	void OnTriggerStay2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player")) {
			if (Input.GetKeyDown (KeyCode.X)) {
				Destroy (gameObject);
			}
		}
	}
}
