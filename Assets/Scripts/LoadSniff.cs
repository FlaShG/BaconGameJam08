using UnityEngine;
using System.Collections;

public class LoadSniff : MonoBehaviour {

	// Use this for initialization
    public float Speed;
    public AudioClip sound;
    public ParticleSystem part;
    private float time=5f;

    // Use this for initialization
    void Start()
    {
        audio.PlayOneShot(sound, 1f);
    }
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(Speed * Time.deltaTime, 0, 0), Space.World);
            if (!part.isPlaying)
                part.Play();
        }
        else
        {
            if (!part.isPlaying)
                part.Pause();
        }
        if(! (time>0f))
        {
            Application.LoadLevel("game 1");
        }
	}
}
