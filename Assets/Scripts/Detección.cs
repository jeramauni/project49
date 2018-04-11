using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script simple para dar información sobre la colisión de un objeto o collider

public class Detección : MonoBehaviour {

	public bool dentro = false;

	void OnCollisionStay2D(Collision2D coll)
	{
		dentro = true;
	}

	void OnCollisionExit2D(Collision2D coll)
	{
		dentro = false;
	}
}
