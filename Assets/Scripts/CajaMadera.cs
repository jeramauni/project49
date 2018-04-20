using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMadera : MonoBehaviour {

	public void Golpeada()  //Destruye la caja
    {
        Destroy(this.gameObject);
    }
}
