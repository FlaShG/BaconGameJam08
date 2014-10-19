﻿using UnityEngine;
using System.Collections;

public class GameEventManager : MonoBehaviour {
    public Cokeline cokeline;
    public Nuttenspawner nuttenspawner;
	// Use this for initialization
	void Start () {
		StartCoroutine (ManageGame ());
	}
	
	// Update is called once per frame
	IEnumerator ManageGame () {
        while (enabled) 
        {
            yield return new WaitForSeconds(10f);//(20f,30f));
            yield return StartCoroutine(MakeCokeline());

        }

	}
    IEnumerator MakeCokeline()
    {
        nuttenspawner.enabled=false;
        var cl = Instantiate (cokeline) as Cokeline;
        yield return StartCoroutine(cl.DoCoke());
        nuttenspawner.enabled = true;
    }
}
