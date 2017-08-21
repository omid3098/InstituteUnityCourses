using UnityEngine;
using System.Collections.Generic;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    [SerializeField]
    private float minX;
    [SerializeField]
    private float offsetX;
    [SerializeField]
    private float offsetY;
    private List<GameObject> obsList;

    private void Awake()
    {
        obsList = new List<GameObject>();
    }

    public void StartBuild()
    {
        Debug.Log("Salam");
        for (int i = 0; i < 5; i++)
        {
            var tempGo = (GameObject)Instantiate(obstaclePrefab, new Vector3(i * offsetX, Random.Range(-offsetY, offsetY), 0), Quaternion.identity);
            tempGo.transform.SetParent(transform, false);
            obsList.Add(tempGo);
        }
    }


    private void Update()
    {
        for (int i = 0; i < obsList.Count; i++)
        {
            var ob = obsList[i];
            if (ob.transform.position.x < minX)
            {
                ob.transform.position += new Vector3(obsList.Count * offsetX, Random.Range(-offsetY, offsetY), 0);
            }
        }
    }
}
