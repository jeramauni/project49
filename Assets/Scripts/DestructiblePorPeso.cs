using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructiblePorPeso: MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject != null && coll.rigidbody.mass >= 2) 
		{
			Destroy (gameObject);
		}
	}
}