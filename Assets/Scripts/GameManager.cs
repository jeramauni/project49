using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance = null;

	public bool personaje;
	public GameObject srt, mch;
	public Transform psrt, pmch;

	void Start()
	{
		personaje = false;
        srt = GameObject.Find ("SirTabaiba");
		mch = GameObject.Find ("Machango");

        psrt = srt.transform;
        pmch = mch.transform;

        if (instance == null)
		{
			instance = this;

			DontDestroyOnLoad(this.gameObject);
		}
		else
		{
			Destroy(this.gameObject);
		}
	}
}