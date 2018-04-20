using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascensor : MonoBehaviour {

	Rigidbody2D ascen;
    public float speed;
	public GameObject activador;
	private Palanca estado;
	private Detección colisionIni, colisionFin;
	public GameObject ini, fin;
	private bool continuidad = true;
	public bool direccion, tipo;
	/*
	direccion = true -> Abajo-Arriba
	direccion = false -> Derecha-Izquierda
	tipo = true -> Se queda abajo
	tipo = false -> Vuelve a la posición inicial
	*/

	void Start () 
	{
		ascen = GetComponent<Rigidbody2D> ();
		estado = activador.GetComponent<Palanca> ();
		colisionIni = ini.GetComponent<Detección> ();
		colisionFin = fin.GetComponent<Detección> ();
	}
	

	void Update () 
	{

		if (tipo == true) {
			if (estado.oN == false) {
				if (colisionFin.dentro == false) {
					if (direccion == true) {
						ascen.velocity = new Vector2 (ascen.velocity.x, -speed);
					} else {
						ascen.velocity = new Vector2 (-speed, ascen.velocity.y);
					}
				} else {
					ascen.velocity = new Vector2 (0f, 0f);
				}
			} else {
				if (colisionIni.dentro == false) {
					if (direccion == true) {
						ascen.velocity = new Vector2 (ascen.velocity.x, speed);
					} else {
						ascen.velocity = new Vector2 (speed, ascen.velocity.y);
					}
				} else {
					ascen.velocity = new Vector2 (0f, 0f);
				}
			}
		} else {
			if (estado.oN == false) {
				if (ascen.velocity == new Vector2 (0f, 0f)) {
					estado.enabled = false;
				}
				ascen.velocity = new Vector2 (ascen.velocity.x, -speed);
				if (colisionFin.dentro == true && continuidad == true) {
					speed = -speed;
					continuidad = false;
				}
				if(ascen.velocity != new Vector2 (0f, 0f)){
					if (colisionIni.dentro == true) {
						ascen.velocity = new Vector2 (0f, 0f);
						estado.enabled = true;
						estado.oN = true;
						speed = -speed;
						continuidad = true;
					}
				}
			}
		}
	}
}
