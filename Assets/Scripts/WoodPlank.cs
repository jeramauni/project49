using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodPlank : MonoBehaviour {

	public GameManager gm;

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.CompareTag ("Player") && !gm.personaje)
			Destroy (this.gameObject);
	}
}
