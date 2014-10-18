using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
public class Trap : MonoBehaviour {

	public Attackpoint[] attackpoints;
	public float duration;
	public int triggercount;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnRatEnter ()
	{
		if (triggercount > 0) {
						GetComponent<Animator> ().SetTrigger ("Trap");
			foreach (Attackpoint element in attackpoints)
			{
				element.Kill();
			}
			triggercount--;
		}
		
	}
}
