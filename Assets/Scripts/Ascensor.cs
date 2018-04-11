using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascensor : MonoBehaviour 
{
	private Animator anim;
	public bool posActual;

	[SerializeField] 
	private bool posIni; 	//Variable que indica la posición inicial del ascensor
							// Arriba = true / Abajo = false
	[SerializeField]
	private Transform top;	//Tope superior
	[SerializeField]
	private Transform bottom;	//Tope inferior

	[SerializeField]
	private float speed;	//Velocidad del ascensor

	void Start ()
	{
		posActual = posIni;
		anim = GetComponent<Animator> ();
		anim.SetBool ("Sube", posActual);

	}
	public void MoverAscensor (bool dir)
	{
		if (dir == true && posActual == false) //Hacia arriba
		{ 
			anim.SetBool ("Sube", true);
			posActual = true;
		}

		else if (dir == false && posActual == true) //Hacia abajo
		{ 
			anim.SetBool ("Sube", false);
			posActual = false;
		}
	}
}
