using UnityEngine;
using System.Collections;

public class ScoreDisplay : MonoBehaviour {

	public TextMesh text;

	void Start () {
        text.text = "Score: $ " + Counter.cash;
	}	
}
