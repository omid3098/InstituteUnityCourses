namespace FlappyBird
{
    using System;
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject birdPrefab;
        [SerializeField]
        private ObjectPoolManager obstacleManager;
        [SerializeField]
        private ObjectPoolManager backgroundManager;
        [SerializeField]
        private CoinUiText _coinUiText;
        public bool _gameOver { get; private set; }
        public Profile _profile { get; private set; }
        private Bird bird;
        private void Awake()
        {
            var birdGo = Instantiate(birdPrefab);
            bird = birdGo.GetComponent<Bird>();
            bird.Init(this);
            bird.transform.SetParent(transform, false);
            obstacleManager.Init();
            backgroundManager.Init();
            _coinUiText.Init(this);
            _profile = new Profile();
            _profile.score = PlayerPrefs.GetInt("score", 0);
        }

        public void GameOver()
        {
            Debug.Log("Game Over");
            bird.Stop();
            obstacleManager.Stop();
            backgroundManager.Stop();
            _gameOver = true;
        }

        public void CollectCoin()
        {
            _profile.score++;
            PlayerPrefs.SetInt("score", _profile.score);
            Debug.Log("Coin: " + _profile.score);
        }
    }
}
