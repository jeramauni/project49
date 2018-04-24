using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeCámara : MonoBehaviour {

	public GameObject[] cams;
	int cambio = 0;

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player")) {
			cambio++;
			cams[(cambio - 1)].SetActive(false);
			cams [cambio].SetActive (true);
			Debug.Log (cams [cambio].name);
		}
	}
	void OnTriggerExit2D (Collider2D coll)
	{
		Destroy (this.gameObject);
	}
}
