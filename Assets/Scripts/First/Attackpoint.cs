using UnityEngine;
using System.Collections;

public class Attackpoint : MonoBehaviour {

	public int killAmount;
	private RatSwarm rats;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Kill()
	{
		rats.KillAmount (killAmount);
		}
}
