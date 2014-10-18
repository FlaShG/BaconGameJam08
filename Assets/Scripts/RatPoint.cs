using UnityEngine;
using System.Collections;

public class RatPoint : MonoBehaviour
{
    public RatSwarm swarm { private set; get; }
    private float enterTime;


	void EnterSwarm(RatSwarm swarm)
    {
        this.swarm = swarm;
        enterTime = Time.time;

        SendMessage("OnSwarmEnter", SendMessageOptions.DontRequireReceiver);
	}

    private void FixedUpdate()
    {
        if(swarm)
        {
            if(Time.time - enterTime > swarm.lineTime)
            {
                swarm = null;
                SendMessage("OnSwarmExit", SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
