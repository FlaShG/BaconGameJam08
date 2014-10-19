using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {
	public GameObject bloodsplash;
    public SoundCollection BodenSounds;
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
			Instantiate(bloodsplash, collision.contacts[0].point,Quaternion.identity);
            audio.PlayOneShot(BodenSounds.GetRandom());
		}
	}
}
