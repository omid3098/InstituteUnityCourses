using UnityEngine;
using System.Collections.Generic;
using System;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    [SerializeField]
    private float minX;
    [SerializeField]
    private float obstacleDistance;
    [SerializeField]
    private float offsetY;
    private List<Obstacle> obsList;

    private void Awake()
    {
        obsList = new List<Obstacle>();
    }

    public void Init()
    {
        Debug.Log("Salam");
        for (int i = 0; i < 5; i++)
        {
            var tempGo = (GameObject)Instantiate(obstaclePrefab, new Vector3(i * obstacleDistance, UnityEngine.Random.Range(-offsetY, offsetY), 0), Quaternion.identity);
            tempGo.transform.SetParent(transform, false);
            obsList.Add(tempGo.GetComponent<Obstacle>());
        }
    }

    public void Stop()
    {
        foreach (var obstacle in obsList)
        {
            obstacle.Stop();
        }
    }

    private void Update()
    {
        for (int i = 0; i < obsList.Count; i++)
        {
            var ob = obsList[i];
            if (ob.transform.position.x < minX)
            {
                ob.transform.position += new Vector3(obsList.Count * obstacleDistance, UnityEngine.Random.Range(-offsetY, offsetY), 0);
            }
        }
    }
}
