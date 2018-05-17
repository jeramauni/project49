using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeCámara : MonoBehaviour {

	public GameObject[] cams;
	bool cambioB = true;
	void OnTriggerEnter2D (Collider2D coll)
	{
			if (coll.gameObject.CompareTag ("Player")) {
			if(cambioB == true)
			{
				cams [0].SetActive (false);
				cams [1].SetActive (true);
				cambioB = false;
			}
			else
			{
				cams [0].SetActive (true);
				cams [1].SetActive (false);
				cambioB = true;
			}
			Debug.Log (cambioB);
		}
	}
}
