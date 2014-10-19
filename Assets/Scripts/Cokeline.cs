using UnityEngine;
using System.Collections;

public class Cokeline : MonoBehaviour {
    public static Cokeline instance { private set; get; }
    public float speed = 10;


    void Awake()
    {
        instance = this;
    }

	// Use this for initialization
	void Start () {
        transform.position = new Vector3 (400, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public IEnumerator DoCoke()
    {
        while (transform.position.x > -240) {
            transform.Translate (Vector3.left * speed * Time.deltaTime);
            yield return null;
        }

        Destroy (gameObject);
    }

    public static bool IsOverCoke(float x)
    {
        if (instance) {
            var pos = instance.transform.position.x;
            return x > pos && x <= pos + 200;
        }
        return false;
    }
}
