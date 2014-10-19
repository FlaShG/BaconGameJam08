using UnityEngine;
using System.Collections;
using System;

public class CountdownTimer : MonoBehaviour {

	public TextMesh text;
    public int timeLimit;
    private float startTime;
    
	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	public void FixedUpdate()
	{
        int remainingSecs = timeLimit - Mathf.FloorToInt(Time.time - startTime);
        if(remainingSecs < 0) {
            Application.Quit();
        }
        if(remainingSecs < 60) {
            text.text = String.Format("0:{0:00}", remainingSecs);
        }
	}
	
}
