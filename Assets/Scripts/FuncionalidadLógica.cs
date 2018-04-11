using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionalidadLógica : MonoBehaviour 
{
	private bool enRangoPalanca;
	private GameObject pal;

	void Start ()
	{
		enRangoPalanca = false;
	}
		
	void Update () 
	{
		//Palancas
		if (Input.GetKeyDown (KeyCode.X) && enRangoPalanca) 
		{
			pal.GetComponent<Palanca> ().UtilizaPalanca ();
		}
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("palanca")) 
		{
			pal = coll.gameObject;
			enRangoPalanca = true;
		}
	}

	void OnTriggerExit2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("palanca")) 
		{
			pal = null;
			enRangoPalanca = false;
		}
	}
}
