using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject birdPrefab;
    [SerializeField]
    private ObstacleManager obstacleManager;

    private GameObject birdGo;
    private void Awake()
    {
        birdGo = Instantiate(birdPrefab);
        birdGo.transform.SetParent(transform, false);
        obstacleManager.StartBuild();
    }
}