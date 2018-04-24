using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pzl12 : MonoBehaviour {

	[SerializeField]
	private GameObject txt1, xKey, fondoTxt, dialogos11;
	private bool inRange;

	void Awake ()
	{
		inRange = false;
		txt1.SetActive (false);
		xKey.SetActive (false);
	}

	void Update ()
	{
		if (inRange && Input.GetKeyDown (KeyCode.X))
			Terminate ();
	}

	void DisplayTxt () //Muestra el texto
	{
		fondoTxt.SetActive (true);
		txt1.SetActive (true);
		Invoke ("ShowBtn", 1);
	}

	void ShowBtn ()		//Muestra la tecla 
	{
		xKey.SetActive (true);
	}

	void HideAll ()	//Oculta el texto si sale de la zona
	{
		xKey.SetActive (false);
		fondoTxt.SetActive (false);
		txt1.SetActive (false);
	}

	void Terminate () //Destruye esta interfaz
	{
		fondoTxt.SetActive (false);
		Destroy (this.gameObject);
	}

	void OnTriggerEnter2D (Collider2D coll)	//Muestra el texto si entra en el área de efecto
	{
		if (coll.gameObject.CompareTag ("Player")) 
		{
			DisplayTxt ();
			inRange = true;
		}
	}

	void OnTriggerExit2D (Collider2D coll)	//Sale del área
	{
		if (coll.gameObject.CompareTag ("Player")) 
		{
			inRange = false;
			HideAll ();
		}
	}
}
