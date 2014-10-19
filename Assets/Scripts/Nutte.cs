using UnityEngine;
using System.Collections;

public class Nutte : MonoBehaviour {
	public float force;
	public float minforce = -150f;
	public float maxforce = -10f;
	// Use this for initialization
	void Start () {
		force = Random.Range (minforce, maxforce);
		gameObject.rigidbody2D.AddForce(new Vector2(Random.Range(-force,force),0));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
