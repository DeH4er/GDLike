using System;
using System.Collections;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public static event Action OnAnimationEnd;
    ParticleSystem particles;

    void Start()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        StartCoroutine(Die());
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(particles.main.startLifetime.constant);
        OnAnimationEnd();
        Destroy(gameObject);
    }
}
