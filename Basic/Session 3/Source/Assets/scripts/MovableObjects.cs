namespace FlappyBird
{
    using UnityEngine;
    public class MovableObjects : MonoBehaviour
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

        public virtual void UpdatePosition(Vector3 newPos)
        {
            transform.position += newPos;
        }
    }
}
