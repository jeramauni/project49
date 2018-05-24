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
	public bool direccion;
	/*
	direccion = true -> Abajo-Arriba
	direccion = false -> Derecha-Izquierda
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
			if (estado.oN == false) {
				if (colisionFin.dentro == false) {
					if (direccion == true) {
						ascen.velocity = new Vector2 (ascen.velocity.x, -speed);
					} else {
						ascen.velocity = new Vector2 (speed, ascen.velocity.y);
					}
				} else {
				if (colisionFin.personaje == false && colisionFin.piedra == false) {
					ascen.velocity = new Vector2 (0f, 0f);
				} else if (colisionFin.personaje == true){
					GameObject.Find ("Jugador").transform.position = new Vector3 (GameObject.Find ("Jugador").transform.position.x, 
						(GameObject.Find ("Jugador").transform.position.y + 3), GameObject.Find ("Jugador").transform.position.z);
				} else if (colisionFin.piedra == true){
					colisionFin.piedraG.transform.position = new Vector3 (colisionFin.piedraG.transform.position.x, 
						(colisionFin.piedraG.transform.position.y + 1), colisionFin.piedraG.transform.position.z);
				}
				}
			} else {
				if (colisionIni.dentro == false) {
					if (direccion == true) {
						ascen.velocity = new Vector2 (ascen.velocity.x, speed);
					} else {
						ascen.velocity = new Vector2 (-speed, ascen.velocity.y);
					}
				} else {
					ascen.velocity = new Vector2 (0f, 0f);
				}
			}
	}
}
