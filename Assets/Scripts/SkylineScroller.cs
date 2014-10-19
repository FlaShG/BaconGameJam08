using UnityEngine;
using System.Collections;

public class SkylineScroller : MonoBehaviour {
	public float speed;
	private float x;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		x = Mathf.Repeat (x + Time.deltaTime * speed, 1);
		renderer.material.mainTextureOffset = new Vector2 (x, 0);
	}


}
