using UnityEngine;
using System.Collections;

public class RatSwarm : MonoBehaviour
{
    [SerializeField]
    private Waypoint waypoint;

    public float speed = 5;

	void Update()
    {
        if(!waypoint) return;

        var dist = Vector3.Distance(transform.position, waypoint.transform.position);
        var way = speed * Time.deltaTime;
        if(dist < way)
        {
            transform.position = waypoint.transform.position;
            waypoint = waypoint.next;
            way -= dist;
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoint.transform.position, way);
	}
}
