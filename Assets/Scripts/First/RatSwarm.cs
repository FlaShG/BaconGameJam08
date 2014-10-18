using UnityEngine;
using System.Collections;

public class RatSwarm : MonoBehaviour
{
    [SerializeField]
    private Waypoint waypoint;
    private TrailRenderer tr;

    public int rats = 10000;
    public float speed = 5;


    void Awake()
    {
        tr = GetComponentInChildren<TrailRenderer>();
        tr.time = lineTime;
    }

	void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            KillAmount(1000);
        }

        tr.time = Mathf.Lerp(tr.time, lineTime, Time.deltaTime * 10);
        tr.material.mainTextureScale = new Vector2(speed * tr.time, 1);
        tr.material.mainTextureOffset = new Vector2(-tr.time * 10, 0);

        if(!waypoint) return;

        var dist = Vector3.Distance(transform.position, waypoint.transform.position);
        var way = speed * Time.deltaTime;
        if(dist < way)
        {
            transform.position = waypoint.transform.position;
            waypoint.SendMessage("EnterSwarm", this, SendMessageOptions.DontRequireReceiver);
            waypoint = waypoint.next;
            way -= dist;
        }
        transform.rotation = Quaternion.LookRotation(waypoint.transform.position - transform.position);

        transform.position = Vector3.MoveTowards(transform.position, waypoint.transform.position, way);

        CheckTriggerPoints();
	}

	public void KillAmount(int amount)
	{
        rats -= amount;
	}

    public float lineTime
    {
        get { return rats * (25f / 10000f / speed); }
    }

    private Vector3 lastGridPosition;
    private void CheckTriggerPoints()
    {
        var gridPosition = transform.position;
        gridPosition.x = Mathf.Round(gridPosition.x);
        gridPosition.z = Mathf.Round(gridPosition.z);

        if(gridPosition != lastGridPosition)
        {
            RaycastHit hit;
            if(Physics.Raycast(gridPosition + Vector3.up * 10, Vector3.down, out hit, 10))
            {
                hit.collider.SendMessage("EnterSwarm", this, SendMessageOptions.DontRequireReceiver);
            }
        }

        lastGridPosition = gridPosition;
    }
}
