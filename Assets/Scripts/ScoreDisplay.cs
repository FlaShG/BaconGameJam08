using UnityEngine;
using System.Collections;

public class ScoreDisplay : MonoBehaviour {

	public TextMesh text;
    private bool canQuit;

	void Start () {
        text.text = "Score: $ " + Counter.cash;
        canQuit = false;
        Counter.cash = 0;
        Counter.multiplier = 1f;
        Invoke("EnableQuit", 5);
	}
    
    void EnableQuit() {
        canQuit = true;
    }
    
    	// Update is called once per frame
	void Update () {
        if(canQuit) {
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
}
