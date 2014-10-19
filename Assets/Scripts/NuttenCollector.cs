using UnityEngine;
using System.Collections;

public class NuttenCollector : MonoBehaviour {

    public ParticleSystem moneysplash;
    public SoundCollection nuttenSounds;
    public SoundCollection OhyeahSounds;
	public int nuttenCollected;
	public Counter counter;
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
			counter.UpdateText(nuttenCollected*100);
            moneysplash.Emit(20);
            audio.PlayOneShot(nuttenSounds.GetRandom());
		}
        if(nuttenCollected%50==0)
        {
            audio.PlayOneShot(OhyeahSounds.GetRandom(),15f);
        }
	}

}
