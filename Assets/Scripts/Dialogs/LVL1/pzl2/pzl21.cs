using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pzl21 : MonoBehaviour 
{
	[SerializeField]
	private GameObject trapBox, msg, cajaTxt;

	private void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player")) 
		{
			ShowTxt ();
			Invoke ("Terminate", 5);
		}
		
	}

	private void ShowTxt ()
	{
		msg.SetActive (true);
		cajaTxt.SetActive (true);
	}

	private void Terminate ()
	{
		cajaTxt.SetActive (false);
		Destroy (msg.gameObject);
		Destroy (this.gameObject);
	}
}
