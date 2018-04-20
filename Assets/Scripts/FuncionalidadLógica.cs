using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionalidadLógica : MonoBehaviour 
{
	private bool enRangoPalanca;
    private GameObject pal;
    public GameManager ctrl;

    void Start ()
	{
		enRangoPalanca = false;
	}
		
	void Update () 
	{
		//Palancas
		if (Input.GetKeyDown (KeyCode.X) && enRangoPalanca) 
		{
            Debug.Log("Click");
            pal.GetComponent<Palanca>().Trigger();
		}

        //Caja madera (Machango)
        if (Input.GetKeyDown(KeyCode.X) && !ctrl.personaje)
        {
            
        }
    }

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("palanca")) 
		{
			pal = coll.gameObject;
			enRangoPalanca = true;
		}
	}

	void OnTriggerExit2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("palanca")) 
		{
			pal = null;
			enRangoPalanca = false;
		}
	}
}
