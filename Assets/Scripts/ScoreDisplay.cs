using UnityEngine;
using System.Collections;

public class ScoreDisplay : MonoBehaviour {

	public TextMesh text;

	void Start () {
        text.text = "Score: $ " + Counter.cash;
	}
    
    	// Update is called once per frame
	void Update () {
#if (UNITY_ANDROID || UNITY_IPHONE) && !UNITY_EDITOR
        if(Input.touchCount>0)
        {
            Application.LoadLevel("menu");
        }
#else
                       if (Input.anyKey)
        {
            Application.LoadLevel("menu");
        }
#endif
	    
	}
}
