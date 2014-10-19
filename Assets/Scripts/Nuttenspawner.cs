using UnityEngine;
using System.Collections;

public class Nuttenspawner : MonoBehaviour {
	public float speed = 1f;
	public Nutte[] nutten;
	// Use this for initialization
	void Start () {
		SpawnNutte ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnNutte()
	{
		Instantiate (nutten[Random.Range(0,nutten.Length)], gameObject.transform.position, Quaternion.Euler(0, 180, 0));
		Invoke ("SpawnNutte", speed);
	}

}
