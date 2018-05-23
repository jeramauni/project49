using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalZonas : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D coll)
	{
		if(coll.gameObject.CompareTag ("Player"))
		{
			SceneManager.LoadScene (2);
		}
	}
}

