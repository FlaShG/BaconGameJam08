using UnityEngine;
using System.Collections;

public class Nuttenspawner : MonoBehaviour {
	public float delay = 1f;
	public Nutte[] nutten;
	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnNutte());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator SpawnNutte()
	{
				while (enabled) {
						Instantiate (nutten [Random.Range (0, nutten.Length)], gameObject.transform.position, Quaternion.Euler (0, 180, 0));
						yield return new WaitForSeconds (delay);
				}
		}

}
