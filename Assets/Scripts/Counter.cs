﻿using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour {

    public static int cash;
    public static float multiplier = 1f;
	public TextMesh text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	}

	public void UpdateText(int count)
	{
		text.text = "$ " + count;
        cash = count;

	}

    public void UpdateText(float count)
    {
        text.text = "Coke Multiplier: " + (int)count + "x";
        multiplier = count;
    }
	
}
