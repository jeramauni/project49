using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menú : MonoBehaviour {

	[SerializeField]
	GameObject fondoTxt, dialogos10, cara;
	[SerializeField]
	GameObject m1, t2, m3, t4, m5, m6, m7, t8, menúB, inicio, maincam, arrow, sr;
	Animator Sr;



	public void dialog11()
	{
		fondoTxt.SetActive (true);
		cara.SetActive (true);
		dialogos10.SetActive (true);
		menúB.SetActive (false);
		sr.GetComponent<Animator> ().enabled = false;
		m1.SetActive (true);
		cara.GetComponent<Animator> ().SetBool("Character", true);
		Invoke ("dialog12", 6f);
	}

	public void dialog12 ()								//Métodos que administran la aparición de los textos
	{
		Destroy (m1.gameObject);
		t2.SetActive (true);
		cara.GetComponent<Animator> ().SetBool("Character", false);
		Invoke ("dialog13", 6f);
	}

	void dialog13 ()
	{
		Destroy (t2.gameObject);
		m3.SetActive (true);
		cara.GetComponent<Animator> ().SetBool("Character", true);
		Invoke ("dialog14", 6f);
	}

	void dialog14 ()
	{
		Destroy (m3.gameObject);
		t4.SetActive (true);
		cara.GetComponent<Animator> ().SetBool("Character", false);
		Invoke ("dialog15", 6f);
	}

	void dialog15 ()
	{
		Destroy (t4.gameObject);
		m5.SetActive (true);
		cara.GetComponent<Animator> ().SetBool("Character", true);
		Invoke ("dialog16", 11f);
	}

	void dialog16 ()
	{
		Destroy (m5.gameObject);
		m6.SetActive (true);
		cara.GetComponent<Animator> ().SetBool("Character", false);
		Invoke ("dialog17", 8f);
	}

	void dialog17 ()
	{
		Destroy (m6.gameObject);
		m7.SetActive (true);
		Invoke ("dialog18", 6f);
	}

	void dialog18 ()
	{
		Destroy (m7.gameObject);
		t8.SetActive (true);
		cara.GetComponent<Animator> ().SetBool("Character", true);
		Invoke ("terminate", 4f);
	}

	void terminate ()						//Acaba con los elementos relacionados con el diálogo actual
	{
		fondoTxt.SetActive (false);
		Destroy (t8.gameObject);
		inicio.SetActive (true);
		maincam.SetActive (false);
		arrow.SetActive (true);
		cara.SetActive (false);
		Destroy (gameObject);	
	}
}
