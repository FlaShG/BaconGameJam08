using UnityEngine;
using System.Collections.Generic;

public class Waypoint : MonoBehaviour
{
    public Waypoint next;

    void OnDrawGizmos()
    {
        if(!next) return;

        Gizmos.color = Color.yellow;

        Gizmos.DrawRay(transform.position, Vector3.up);
        Gizmos.DrawLine(transform.position + Vector3.up, next.transform.position);
    }
}
