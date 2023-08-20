using System;
using System.Collections;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public static event Action OnAnimationEnd;

    IEnumerator Start()
    {
        ParticleSystem particles = GetComponentInChildren<ParticleSystem>();
        yield return new WaitForSeconds(particles.main.startLifetime.constant);
        OnAnimationEnd();
        Destroy(gameObject);
    }
}
