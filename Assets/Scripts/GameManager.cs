using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;

	public bool personaje;
	public GameObject srt, mch;
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
            Destroy(this.gameObject);
        }

        srt = GameObject.Find("SirTabaiba");
        psrt = srt.transform;
        mch = GameObject.Find("Machango");
        pmch = mch.transform;
    }

    private void Update()
    {
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
    }

}