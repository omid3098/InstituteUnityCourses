namespace FlappyBird
{
    using UnityEngine;
    using System.Collections;
    using System;

    public class Bird : MonoBehaviour
    {
        private GameManager mygameManager;
        private Rigidbody _rigidBody;
        public void Init(GameManager _gm)
        {
            mygameManager = _gm;
            _rigidBody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            if (mygameManager._gameOver == true) return;
            if (Input.GetMouseButtonDown(0))
            {
                _rigidBody.velocity = Vector3.zero;
                _rigidBody.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "obstacle")
            {
                mygameManager.GameOver();
            }
            else if (other.tag == "coin")
            {
                mygameManager.CollectCoin();
                other.gameObject.SetActive(false);
            }
        }

        public void Stop()
        {
            _rigidBody.useGravity = false;
            _rigidBody.velocity = Vector3.zero;
        }
    }
}