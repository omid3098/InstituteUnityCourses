namespace FlappyBird
{
    using UnityEngine;
    using System.Collections.Generic;
    using System;

    public class ObjectPoolManager : MonoBehaviour
    {
        public GameObject objectPrefab;
        [SerializeField]
        private float minX;
        [SerializeField]
        private float _distance;
        [SerializeField]
        private float offsetY;
        private List<MovableObjects> obsList;

        public void Init()
        {
            obsList = new List<MovableObjects>();
            for (int i = 0; i < 5; i++)
            {
                var tempGo = (GameObject)Instantiate(objectPrefab, new Vector3(i * _distance, UnityEngine.Random.Range(-offsetY, offsetY), 0), Quaternion.identity);
                tempGo.transform.SetParent(transform, false);
                obsList.Add(tempGo.GetComponent<MovableObjects>());
            }
            StopMove();
        }

        public void StopMove()
        {
            foreach (var _object in obsList)
            {
                _object.Stop();
            }
        }
        public void StartMove()
        {
            foreach (var _object in obsList)
            {
                _object.StartMove();
            }
        }

        private void Update()
        {
            for (int i = 0; i < obsList.Count; i++)
            {
                var movable = obsList[i];
                if (movable.transform.position.x < minX)
                {
                    // movable.transform.position += new Vector3(obsList.Count * _distance, UnityEngine.Random.Range(-offsetY, offsetY), 0);
                    movable.UpdatePosition(new Vector3(obsList.Count * _distance, UnityEngine.Random.Range(-offsetY, offsetY), 0));

                }
            }
        }
    }
}