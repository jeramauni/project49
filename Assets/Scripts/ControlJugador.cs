using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour{

	private Detección colisionI, colisionD, colisionS;
	public float alturaSalto, velMovimiento;
	public GameObject izq, der, sue;
    Rigidbody2D rb;

	void Awake()
	{
		rb = GetComponent<Rigidbody2D> ();
		colisionI = izq.GetComponent<Detección> ();
		colisionD = der.GetComponent<Detección> ();
		colisionS = sue.GetComponent<Detección> ();
	}

    private void Update()
    {
        GetComponent<Animator>().SetFloat("velocity", rb.velocity.x);
    }

    void FixedUpdate()
	{
		//MOVIMIENTO DEL PERSONAJE

		    //Salto ("Flecha arriba")
		    if(((Input.GetKey(KeyCode.UpArrow)) && colisionS.dentro == true))
		    {
			    rb.velocity = new Vector2 (rb.velocity.x , rb.velocity.y + alturaSalto);
		    }

            //Mover a la derecha ("Flecha derecha")
            if (((Input.GetKey(KeyCode.RightArrow)) && colisionD.dentro == false) || ((Input.GetKey(KeyCode.RightArrow)) && colisionS.dentro == true))
            {
                rb.velocity = new Vector2(velMovimiento, rb.velocity.y);
            }

            //Mover a la izquierda ("Flecha izquierda")
            if (((Input.GetKey(KeyCode.LeftArrow)) && colisionI.dentro == false) || ((Input.GetKey(KeyCode.LeftArrow)) && colisionS.dentro == true))
            {
                rb.velocity = new Vector2(-velMovimiento, rb.velocity.y);
            }
        
       
    }
}