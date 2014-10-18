using UnityEngine;
using System.Collections;

public class NuttenCollector : MonoBehaviour {

	public int nuttenCollected;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.GetComponent<Nutte> ()) 
		{
			Destroy(collision.gameObject);
			nuttenCollected++;
		}
	}

}
