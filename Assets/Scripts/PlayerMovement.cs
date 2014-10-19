using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float power = 300;
    private int koks;
    public Counter counter;


	void FixedUpdate()
    {
#if (UNITY_ANDROID || UNITY_IPHONE) && !UNITY_EDITOR
        var left = 0;
        var right = 0;
        var half = Screen.width / 2f;

        foreach(var touch in Input.touches)
        {
            if(touch.position.x < half)
            {
                left = -1;
            }
            else
            {
                right = 1;
            }
        }

        var movement = left + right;
#else
        var movement = Input.GetAxis("Horizontal");
#endif

        rigidbody2D.AddForce(new Vector3(movement * power * Time.deltaTime * 50, 0, 0));

        var pos = transform.position;
        pos.y = 0;
        transform.position = pos;

        var sniff = Input.GetKey (KeyCode.Space);

        if (sniff) {
            if(Cokeline.IsOverCoke(transform.position.x)){
                koks += (int)Time.deltaTime;
                counter.UpdateText(koks);
            }
            else
            {
                sniff = false;
            }
        }

        GetComponent<Animator> ().SetBool ("Sniff", sniff);
	}
}
