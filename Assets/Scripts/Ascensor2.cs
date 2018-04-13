using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascensor2 : MonoBehaviour {

	Rigidbody2D ascen;
	public float speed;
	private float speedG;
	public GameObject activador;
	private Palanca estado;
	private Detección colisionIni, colisionFin;
	public GameObject ini, fin;
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
		speedG = speed;
		if (tipo == false) {
			ascen.velocity = new Vector2 (ascen.velocity.x, -speed);
		}
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
			/*if (estado.oN == false) {
				if (direccion == true) {
					ascen.velocity = new Vector2 (ascen.velocity.x, -speed);
				} else {
					ascen.velocity = new Vector2 (-speed, ascen.velocity.y);
				}
			} else {
				if (direccion == true) {
					ascen.velocity = new Vector2 (ascen.velocity.x, speed);
				} else {
					ascen.velocity = new Vector2 (speed, ascen.velocity.y);
				}
			}*/
			if (estado.oN == false) {
				ascen.velocity = new Vector2 (ascen.velocity.x, speed);
				if (colisionIni.dentro == true) {
					speed = -speed;
				}
				if (colisionFin.dentro == true) {
					//speed = -speed;
				}
			} else {
				ascen.velocity = new Vector2 (0f, 0f);
			}
		}
			/*if (colisionFin.dentro == true) {
				speed = -speed;
			}
			if (colisionIni.dentro == true) {
				ascen.velocity = new Vector2 (0f, 0f);				
			} //else {
				if (estado.oN == false) {
				if (colisionIni.dentro == false) {
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
		//	}
		}*/
	}
}
