namespace FlappyBird
{
    using UnityEngine;
    using System.Collections;
    using System;

    public class Obstacle : MovableObjects
    {
        public override void UpdatePosition(Vector3 newPos)
        {
            base.UpdatePosition(newPos);
            EnableCoin();
        }

        private void EnableCoin()
        {
            var _coin = transform.Find("coin");
            if (_coin != null) _coin.gameObject.SetActive(true);
        }
    }
}
