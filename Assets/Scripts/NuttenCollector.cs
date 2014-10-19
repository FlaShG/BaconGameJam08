using UnityEngine;
using System.Collections;

public class NuttenCollector : MonoBehaviour {

    public SoundCollection nuttenSounds;
    public SoundCollection OhyeahSounds;
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
            audio.PlayOneShot(nuttenSounds.GetRandom());
		}
        if(nuttenCollected==50)
        {
            audio.PlayOneShot(OhyeahSounds.GetRandom(),4.5f);
        }
	}

}
