using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObjetos : MonoBehaviour {

	Rigidbody2D bloque;
	public GameManager gm; 

	void Start () 
	{
		bloque = GetComponent<Rigidbody2D> ();
		gm = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	}

	void Update () 
	{

		transform.rotation = Quaternion.identity;
		 
		if (gm.personaje == true)
				bloque.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
		
		else
		{
			bloque.constraints = RigidbodyConstraints2D.None;	
		}
	}
}
