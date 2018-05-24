using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flor : MonoBehaviour {

	[SerializeField]
	private GameObject CajaTxt, txt, icono, caja;
	private bool ready;

	void Awake ()
	{
		txt.SetActive (false);
		icono.SetActive (false);
		ready = false;
	}

	private void OnTriggerEnter2D (Collider2D coll) 
	{
		if (coll.gameObject.CompareTag ("Player")) 
		{
			ShowTxt ();
			Invoke("ShowIcon", 1.5f);
			ready = true;
		}
	}

	private void ShowIcon ()
	{
		icono.SetActive (true);
	}

	private void ShowTxt () 
	{
		txt.SetActive (true);
		CajaTxt.SetActive (true);
	}

	void Update ()
	{
		if (ready && caja == null)
			Terminate ();
	}

	private void Terminate()
	{
		txt.SetActive (false);
		icono.SetActive (false);
		CajaTxt.SetActive (false);
		Destroy (this.gameObject);
	}
}
