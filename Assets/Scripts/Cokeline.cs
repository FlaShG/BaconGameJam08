using UnityEngine;
using System.Collections;

public class Cokeline : MonoBehaviour {

    public float speed = 10;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3 (20, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public IEnumerator DoCoke()
    {
        while (transform.position.x > -40) {
            transform.Translate (Vector3.left * speed * Time.deltaTime);
            yield return null;
        }
    }
}
