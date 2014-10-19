using UnityEngine;
using System.Collections;

public class Blinker : MonoBehaviour
{
	void Update()
    {
        renderer.enabled = Mathf.Repeat(Time.time, 0.2f) < 0.1f;
	}

	void OnDisable()
    {
        renderer.enabled = false;
	}
}
