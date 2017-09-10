using UnityEngine;
using System.Collections;
using System;

public class Bird : MonoBehaviour
{
    private readonly float gravity = -0.05f;
    private float force;
    private bool clicked;
    private readonly float forceDuration = 0.5f;
    private float ellapsedTime;
    private GameManager mygameManager;

    private bool _stop;

    void Awake()
    {
        clicked = false;
        ResetValues();
    }

    public void Init(GameManager _gm)
    {
        mygameManager = _gm;
    }

    private void ResetValues()
    {
        force = 10f;
        ellapsedTime = 0;
    }

    public void Stop()
    {
        _stop = true;
    }

    void Update()
    {
        if (_stop == true) return;
        if (Input.GetMouseButtonDown(0))
        {
            clicked = true;
            ResetValues();
        }

        if (!clicked) transform.position += new Vector3(0, gravity, 0);
        else
        {
            ellapsedTime += Time.deltaTime;
            if (ellapsedTime >= forceDuration)
            {
                clicked = false;
                ellapsedTime = 0;
            }
            transform.position += new Vector3(0, force * Time.deltaTime, 0);
            force /= 1.1f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obstacle")
        {
            mygameManager.GameOver();
        }
    }
}
