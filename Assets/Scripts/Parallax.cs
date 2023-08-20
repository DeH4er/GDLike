using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    new Camera camera;
    float backgroundLength;
    float startPosition;
    [SerializeField] float offsetPerSecond;

    void Start()
    {
        camera = Camera.main;
        backgroundLength = GetComponent<SpriteRenderer>().bounds.size.x;
        startPosition = transform.position.x;
    }

    void Update()
    {
        float distanceLeft = camera.transform.position.x * offsetPerSecond;
        float distance = camera.transform.position.x * (1 - offsetPerSecond);
        transform.position = new Vector3(startPosition + distance, transform.position.y, transform.position.z);

        if (distanceLeft > startPosition + backgroundLength)
        {
            startPosition += backgroundLength;
        }
    }
}
