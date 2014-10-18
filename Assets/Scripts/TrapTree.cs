using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class Trap : MonoBehaviour {

	public int triggercount;
	public int killAmount;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnRatEnter (RatSwarm rats)
	{
		if (triggercount > 0) {
						GetComponent<Animator> ().SetTrigger ("Trap");
						rats.KillAmount (killAmount);
						triggercount--;
				}

	}
}
