using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour {

    public bool oN, tipo;
	/*
	 tipo = true -> placa de presión
	 tipo = false -> Palanca
	 */

    private void Start()
    {
			GetComponent<Animator>().SetBool("state", oN);
    }
    public void Trigger ()
    {
		if (tipo == false) {
			oN = !oN;

			GetComponent<Animator> ().SetBool ("state", oN);
		}
     
    }
	void OnCollisionStay2D (Collision2D coll)
	{
		if(tipo == true && coll.rigidbody.mass >= 2) oN = false;
		GetComponent<Animator> ().SetBool ("state", oN);
	}
	void OnCollisionExit2D (Collision2D coll)
	{
		if(tipo == true && coll.rigidbody.mass >= 2) oN = true;
		GetComponent<Animator> ().SetBool ("state", oN);
	}
}
