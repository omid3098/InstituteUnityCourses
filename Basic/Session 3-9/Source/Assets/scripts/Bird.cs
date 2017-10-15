namespace FlappyBird
{
    using UnityEngine;
    using System.Collections;
    using System;

    public class Bird : MonoBehaviour
    {
        private GameManager mygameManager;
        private Rigidbody _rigidBody;
        private Vector3 tmpVelocity;

        public void Init(GameManager _gm)
        {
            mygameManager = _gm;
            _rigidBody = GetComponent<Rigidbody>();
            tmpVelocity = _rigidBody.velocity;
            StopMove();
            ResetTransform();
        }

        void Update()
        {
            if (mygameManager.gameOver == true) return;
            if (!_rigidBody.useGravity) return;
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

        internal void ResetTransform()
        {
            transform.position = Vector3.zero;
        }

        public void StopMove()
        {
            _rigidBody.useGravity = false;
            tmpVelocity = _rigidBody.velocity;
            _rigidBody.velocity = Vector3.zero;
        }
        public void StartMove()
        {
            _rigidBody.useGravity = true;
            _rigidBody.velocity = Vector3.zero;
        }
    }
}