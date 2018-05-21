using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;

	public bool personaje;
	public GameObject srt, mch, per;
	public Transform psrt, pmch;

    private void Start()
    {

        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
			Destroy(gameObject);
        }
		per = GameObject.Find ("Jugador");
        srt = GameObject.Find("SirTabaiba");
        psrt = srt.transform;
        mch = GameObject.Find("Machango");
        pmch = mch.transform;
    }
	void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.Z) && per.GetComponent<CambiaPersonaje> ().allowed)
		{
			personaje = per.GetComponent<CambiaPersonaje> ().CdP ();
		}
	}
    private void Update()
    {

		Debug.Log (personaje);
		if (per == null) {
			per = GameObject.Find ("Jugador");
		}
        if(srt == null)
        {
            srt = GameObject.Find("SirTabaiba");
            psrt = srt.transform;
        }

        if (mch == null)
        {
            mch = GameObject.Find("Machango");
            pmch = mch.transform;
        }
	//	personaje = per.GetComponent<CambiaPersonaje> ().gm.personaje;
    }

}