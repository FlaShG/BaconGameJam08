using UnityEngine;
using System.Collections;

public class Nuttenspawner : MonoBehaviour {
	public float delay = 1f;
	public Nutte[] nutten;
    public int spawnRange;
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
						Instantiate (nutten [Random.Range (0, nutten.Length)],transform.position + new Vector3(Random.Range(-spawnRange/2,spawnRange/2),0,0), Quaternion.Euler (0, 180, 0));
						yield return new WaitForSeconds (delay);
				}
		}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position + Vector3.left * spawnRange / 2, Vector3.right * spawnRange);
    }

}
