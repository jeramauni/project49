using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Menú : MonoBehaviour {

	public AudioMixer audio;
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
}
