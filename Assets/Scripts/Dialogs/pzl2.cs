using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pzl2 : MonoBehaviour {

	[SerializeField]
	private GameObject txt1, xKey, fondoTxt;

	void Awake ()
	{
		txt1.SetActive (false);
		xKey.SetActive (false);
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

	void Terminate () 
	{
		fondoTxt.SetActive (false);
		Destroy (this.gameObject);
	}
}
