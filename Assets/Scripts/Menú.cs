using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Menú : MonoBehaviour {

	public AudioMixer audio;

	public void Jugar()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void Volumen (float volumen)
	{
		audio.SetFloat ("Volumen", volumen);
	}
	public void VolverAlMenú()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 1);
	}
}
