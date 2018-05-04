using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Menú : MonoBehaviour {

	public AudioMixer audio;

	void OnTriggerEnter2D (Collider2D coll)
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		Debug.Log ("asdas");
	}
	public void Volumen (float volumen)
	{
		audio.SetFloat ("Volumen", volumen);
	}
	public void VolverAlMenú()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 1);
	}
	public void Salir()
	{
		Application.Quit ();
	}
}
