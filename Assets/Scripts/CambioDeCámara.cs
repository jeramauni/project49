using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeCámara : MonoBehaviour {

	public GameObject[] cams;
	bool cambioB = true;
	public bool returnable = true;
	private bool open = true;
	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player") && open) {
			if(cambioB == true)
			{
				cams [0].SetActive (false);
				cams [1].SetActive (true);
				cambioB = false;
				if (returnable == false)
					open = false;
			}
			else if (open)
			{
				cams [0].SetActive (true);
				cams [1].SetActive (false);
				cambioB = true;
			}
			Debug.Log (cambioB);
		}
	}

	void Cooldown ()
	{
		open = true;
	}
}
