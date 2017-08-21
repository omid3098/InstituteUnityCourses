using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{
    private float force;
    private bool clicked;
    private float forceDuration;
    private float ellapsedTime;

    void Awake()
    {
        force = 0.1f;
        clicked = false;
        forceDuration = 0.5f;
        ellapsedTime = 0;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clicked = true;
            force = 0.1f;
            ellapsedTime = 0;
        }

        if (!clicked) transform.position += new Vector3(0, -0.05f, 0);
        else
        {
            ellapsedTime += Time.deltaTime;
            if (ellapsedTime >= forceDuration)
            {
                clicked = false;
                ellapsedTime = 0;
            }
            transform.position += new Vector3(0, force, 0);
            force /= 1.1f;
        }
    }
}
