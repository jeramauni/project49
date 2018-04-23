using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pzl1 : MonoBehaviour {
	
	[SerializeField]
	GameObject zbutton, fondoTxt, text1, jugador, barrier1;
	 
	private bool stop;

	// Use this for initialization
	void Start () 
	{
		stop = false;
		fondoTxt.SetActive (true);
		text1.SetActive (true);
		zbutton.SetActive (false);
		jugador.GetComponent<CambiaPersonaje> ().allowed = false; //No permite cambiar de personaje
		Invoke("dialog10", 4.5f);
	}

	void dialog10 ()
	{
		zbutton.SetActive (true);
		jugador.GetComponent<CambiaPersonaje> ().allowed = true;
		stop = true;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Z) && stop) 	//A partir del momento adecuado si se pulsa z
		{											//desaparece el txt1 y la barrera invisible
			fondoTxt.SetActive (false);
			Destroy (text1.gameObject);
			Destroy (zbutton.gameObject);
			Destroy (barrier1.gameObject);
		}
	}
	

}
