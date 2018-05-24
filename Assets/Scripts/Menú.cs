using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Menú : MonoBehaviour {
	
	public GameObject zona1, zona2, zona3;
	public bool zonas1 = false, zonas2 = false, zonas3 = false;
	public AudioMixer audio;
	public GameManager gm;

	void Update () 
	{
		if (gm == null) { gm = GameObject.Find ("GameManager").GetComponent<GameManager> (); }
		if (gm != null) {zonas1 = gm.zona1; zonas2 = gm.zona2; zonas3 = gm.zona3; Zonas();}
	}
	void OnTriggerEnter2D (Collider2D coll)
	{
		SceneManager.LoadScene (1);
	}

	public void Volumen (float volumen)
	{
		audio.SetFloat ("Volumen", volumen);
	}

	public void VolverAlMenú()
	{
		//Destroy (GameObject.Find ("Canvas"));
		SceneManager.LoadScene (0);
	}

	public void Salir()
	{
		Application.Quit ();
	}

	public void Zonas()
	{
		if (zonas1 == true) {zona1.SetActive (true);}
		else{zona1.SetActive(false);}
		if (zonas2 == true) {zona2.SetActive (true);}
		else{zona2.SetActive(false);}
		if (zonas3 == true) {zona3.SetActive (true);}
		else{zona3.SetActive(false);}
	}

	public void CargarZona1()
	{
		SceneManager.LoadScene (1);
	}
	public void CargarZona2()
	{
		SceneManager.LoadScene (2);
	}
	public void CargarZona3()
	{
		SceneManager.LoadScene (3);
	}
}
