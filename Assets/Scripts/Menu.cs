using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
#if (UNITY_ANDROID || UNITY_IPHONE) && !UNITY_EDITOR
        if(Input.touchCount>0)
        {
            Application.LoadLevel("game 1");
        }
#else
                       if (Input.anyKey)
        {
            Application.LoadLevel("game 1");
        }
#endif
	    
	}
}
