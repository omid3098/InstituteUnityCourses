namespace FlappyBird
{
    using System;
    using UnityEngine;
    public class MovableObjects : MonoBehaviour
    {
        [SerializeField]
        private float speed;
        private float tmpSpeed;
        void Update()
        {
            transform.position += new Vector3(-speed, 0, 0);
        }

        public void Stop()
        {
            tmpSpeed = speed;
            speed = 0;
        }

        public void StartMove()
        {
            speed = tmpSpeed;
        }

        public virtual void UpdatePosition(Vector3 newPos)
        {
            transform.position += newPos;
        }
    }
}
