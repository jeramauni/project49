using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionalidadLógica : MonoBehaviour 
{
	private bool enRangoPalanca, enRangoCaja;
    private GameObject pal, caja;
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
            pal.GetComponent<Palanca>().Trigger();
		}

        //Caja madera (Machango)
        if (Input.GetKeyDown(KeyCode.X) && !ctrl.personaje && enRangoCaja)
        {
            caja.GetComponent<CajaMadera>().Golpeada(); //Llama al método que destruye la caja
        }
    }

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("palanca")) //En rango de una palanca
		{
			pal = coll.gameObject;
			enRangoPalanca = true;
		}

        if(coll.gameObject.CompareTag("caja"))    //En rango de una caja
        {
            caja = coll.gameObject;
            enRangoCaja = true;
        }
    }

	void OnTriggerExit2D (Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("palanca")) 
		{
			pal = null;
			enRangoPalanca = false;
		}

        if (coll.gameObject.CompareTag("caja"))    //En rango de una caja
        {
            caja = coll.gameObject;
            enRangoCaja = false;
        }
    }
}
