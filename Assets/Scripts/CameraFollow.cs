using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform what;

    void Start()
    {
        transform.position = new Vector3(what.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        if (what != null)
        {
            transform.position = new Vector3(what.position.x, transform.position.y, transform.position.z);
        }
    }
}
