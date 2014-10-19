using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float power = 120;

	void FixedUpdate()
    {
        rigidbody2D.AddForce(new Vector3(Input.GetAxis("Horizontal") * power * Time.deltaTime * 50, 0, 0));

        var pos = transform.position;

        pos.y = 0;

        transform.position = pos;
	}
}
