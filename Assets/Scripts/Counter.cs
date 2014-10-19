using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour {

	public TextMesh text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	}

	public void UpdateText(int count)
	{
		text.text = "$ " + count;
	}
	
}
