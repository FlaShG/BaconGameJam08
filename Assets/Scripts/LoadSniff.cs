using UnityEngine;
using System.Collections;

public class LoadSniff : MonoBehaviour {

    public float Speed;
    public AudioClip sound;

	// Use this for initialization
	void Start () {
        audio.PlayOneShot(sound, 1f);
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(new Vector3(-speed*Time.deltaTime,0,0));
        if (transform.localScale.x > 0f)
        {
            transform.localScale -= new Vector3(Speed * Time.deltaTime, 0, 0);
            transform.Translate(new Vector3(Speed * Time.deltaTime, 0, 0));
        }
        else
            transform.localScale = new Vector3(0, 0, 0);
	}
}
