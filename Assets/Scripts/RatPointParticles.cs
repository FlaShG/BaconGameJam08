using UnityEngine;
using System.Collections;

public class RatPointParticles : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem particles;


	void OnSwarmEnter()
    {
        particles.Play();
	}

    void OnSwarmExit()
    {
        particles.Stop();
    }
}
