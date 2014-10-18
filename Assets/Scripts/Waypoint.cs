using UnityEngine;
using System.Collections.Generic;

public class Waypoint : MonoBehaviour
{
    [SerializeField]
    private Waypoint _next;
    public Waypoint next { get { return _next; } }
}
