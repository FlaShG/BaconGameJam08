using UnityEngine;
using System.Collections;

public class Nutte : MonoBehaviour {
	public float force;
	// Use this for initialization
	void Start () {
		force = Random.Range (-100f, 100f);
		gameObject.rigidbody2D.AddForce(new Vector2(force,0));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
