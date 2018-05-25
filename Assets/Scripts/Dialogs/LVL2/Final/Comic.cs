using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comic : MonoBehaviour {

	[SerializeField]
	GameObject fondoTxt, dialogos10, caras, menú, camara;
	[SerializeField]
	GameObject c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, créditosF;

	// Use this for initialization
	void Start () 
	{
		//Inicializa el primer diálogo y desactiva los sucesores
		fondoTxt.SetActive (false);
		caras.SetActive (false);
		menú.SetActive (false);
		camara.SetActive (true);
		c1.SetActive (true);
		c2.SetActive (false);
		c3.SetActive (false);
		c4.SetActive (false);
		c5.SetActive (false);
		c6.SetActive (false);
		c7.SetActive (false);
		c8.SetActive (false);
		c9.SetActive (false);
		c10.SetActive (false);
		c11.SetActive (false);
		c12.SetActive (false);
		Invoke("dialog12", 3f);
	}

	void dialog12 ()								//Métodos que administran la aparición de los textos
	{
		Destroy (c1.gameObject);
		c2.SetActive (true);
		Invoke ("dialog13", 3f);
	}

	void dialog13 ()
	{
		Destroy (c2.gameObject);
		c3.SetActive (true);
		Invoke ("dialog14", 3f);
	}

	void dialog14 ()
	{
		Destroy (c3.gameObject);
		c4.SetActive (true);
		Invoke ("dialog15", 3f);
	}

	void dialog15 ()
	{
		Destroy (c4.gameObject);
		c5.SetActive (true);
		Invoke ("dialog16", 3f);
	}

	void dialog16 ()
	{
		Destroy (c5.gameObject);
		c6.SetActive (true);
		Invoke ("dialog17", 3f);
	}

	void dialog17 ()
	{
		Destroy (c6.gameObject);
		c7.SetActive (true);
		Invoke ("dialog18", 3f);
	}

	void dialog18 ()
	{
		Destroy (c7.gameObject);
		c8.SetActive (true);
		Invoke ("dialog19", 3f);
	}

	void dialog19 ()
	{
		Destroy (c8.gameObject);
		c9.SetActive (true);
		Invoke ("dialog20", 3f);
	}

	void dialog20 ()
	{
		Destroy (c9.gameObject);
		c10.SetActive (true);
		Invoke ("dialog21", 3f);
	}

	void dialog21 ()
	{
		Destroy (c10.gameObject);
		c11.SetActive (true);
		Invoke ("dialog22", 3f);
	}

	void dialog22 ()
	{
		Destroy (c11.gameObject);
		c12.SetActive (true);
		Invoke ("dialog23", 3f);
	}

	void dialog23 ()
	{
		Destroy (c12.gameObject);
		créditosF.SetActive (true);
		Invoke ("terminate", 6f);
	}

	void terminate ()						//Acaba con los elementos relacionados con el diálogo actual
	{
		fondoTxt.SetActive (false);
		Destroy (dialogos10.gameObject);
		Destroy (this.gameObject);
		SceneManager.LoadScene (0);
	}
}
