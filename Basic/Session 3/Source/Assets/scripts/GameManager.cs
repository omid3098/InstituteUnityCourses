using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject birdPrefab;
    [SerializeField]
    private ObstacleManager obstacleManager;

    private Bird bird;
    private void Awake()
    {
        var birdGo = Instantiate(birdPrefab);
        bird = birdGo.GetComponent<Bird>();
        bird.Init(this);
        bird.transform.SetParent(transform, false);
        obstacleManager.Init();
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        bird.Stop();
        obstacleManager.Stop();
    }
}