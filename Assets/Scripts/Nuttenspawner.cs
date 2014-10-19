using UnityEngine;
using System.Collections;

public class Nuttenspawner : MonoBehaviour {
	public float delay = 1f;
    private float lastNutte;
	public Nutte[] nutten;
    public int spawnRange;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        lastNutte += Time.deltaTime;
        while (lastNutte > delay) 
        {
            Instantiate (nutten [Random.Range (0, nutten.Length)],transform.position + new Vector3(Random.Range(-spawnRange/2,spawnRange/2),0,0), Quaternion.Euler (0, 180, 0));
            lastNutte -= delay;
        }
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position + Vector3.left * spawnRange / 2, Vector3.right * spawnRange);
    }

}
