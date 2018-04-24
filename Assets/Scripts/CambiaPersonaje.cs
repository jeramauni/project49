using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaPersonaje : MonoBehaviour
{
    public GameManager gm;
	public bool allowed;

	[SerializeField]
	private GameObject caras;
	private Animator converAnim;

	[SerializeField]
	private float coolDown;
	private float coolDownTimer;

	void Start ()
	{
		allowed = false;
		converAnim = caras.GetComponent<Animator> (); //Obtiene el animador de las caras
		CdP();
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
		if (Input.GetKeyDown(KeyCode.Z) && allowed)
        {
            CdP();
        }
    }
   public void CdP()
    {
		if (gm.personaje == false && coolDownTimer == 0)	//Cambia a Sir Tabaiba
        {
            gm.personaje = true;										
			Vector3 pos = new Vector3 (gm.pmch.position.x, gm.pmch.position.y + 0.45f, 1); //Instancia en la posición donde se encontrara el otro personaje
			gm.psrt.position = pos;
            gm.srt.SetActive(true);
            gm.mch.SetActive(false);
			coolDownTimer = coolDown;

			converAnim.SetBool ("Character", true);	//Cambia a la cara de Tabaiba
        }
		else if (gm.personaje == true && coolDownTimer == 0)	//Cambia a Machango
        {
            gm.personaje = false;
			Vector3 pos = new Vector3 (gm.psrt.position.x, gm.psrt.position.y - 0.45f, 1);
			gm.pmch.position = pos;
            gm.mch.SetActive(true);
            gm.srt.SetActive(false);
			coolDownTimer = coolDown;

			converAnim.SetBool ("Character", false);	//Cambia a la cara de Machango
        }
    }
}