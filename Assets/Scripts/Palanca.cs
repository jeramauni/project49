using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour {

    public bool oN;

    private void Start()
    {
        GetComponent<Animator>().SetBool("state", oN);
    }
    public void Trigger ()
    {
        oN = !oN;

      GetComponent<Animator>().SetBool("state", oN);
     
    }
}
