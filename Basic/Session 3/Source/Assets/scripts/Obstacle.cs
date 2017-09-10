using UnityEngine;
using System.Collections;
using System;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speed;
    void Update()
    {
        transform.position += new Vector3(-speed, 0, 0);
    }

    public void Stop()
    {
        speed = 0;
    }
}
