using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour 
{
	private Animator anim;

	[SerializeField]
	private bool oN;

	[SerializeField]
	private GameObject ascensor1;

	void Start()
	{
		anim = GetComponent<Animator> ();
		anim.SetBool ("state", oN);
	}

	public void UtilizaPalanca ()
	{
		oN = !oN; //Cambia el estado de la palanca
		ascensor1.GetComponent<Ascensor>().MoverAscensor(oN);
		anim.SetBool ("state", oN);
	}
}
