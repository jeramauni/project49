using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaPersonaje : MonoBehaviour
{
    public GameManager gm;

	[SerializeField]
	private GameObject caras;
	private Animator converAnim;

	[SerializeField]
	private float coolDown;
	private float coolDownTimer;

	void Start ()
	{
		converAnim = caras.GetComponent<Animator> (); //Obtiene el animador de las caras
	}

	void Update ()
	{
		if (coolDownTimer < 0)
			coolDownTimer = 0;

		if (coolDownTimer > 0)
			coolDownTimer -= Time.deltaTime;

	}

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            CdP();
        }
    }
   public void CdP()
    {

		if (gm.personaje == false && coolDownTimer == 0)	//Cambia a Sir Tabaiba
        {
            gm.personaje = true;										
			Vector3 pos = new Vector3 (gm.pmch.position.x, gm.pmch.position.y + 1, gm.pmch.position.z); //Instancia en la posición donde se encontrara el otro personaje
			gm.psrt.position = pos;
            gm.srt.SetActive(true);
            gm.mch.SetActive(false);
			coolDownTimer = coolDown;

			converAnim.SetBool ("Character", true);	//Cambia a la cara de Tabaiba
        }
		else if (gm.personaje == true && coolDownTimer == 0)	//Cambia a Machango
        {
            gm.personaje = false;
			gm.pmch.position = gm.psrt.position;	//Instancia en la posición donde se encontrara el otro personaje
            gm.mch.SetActive(true);
            gm.srt.SetActive(false);
			coolDownTimer = coolDown;

			converAnim.SetBool ("Character", false);	//Cambia a la cara de Machango
        }
    }
}