using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speed;
    void Update()
    {
        transform.position += new Vector3(-speed, 0, 0);
    }
}
