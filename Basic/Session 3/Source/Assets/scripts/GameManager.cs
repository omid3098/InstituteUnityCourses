namespace FlappyBird
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;

    public class GameManager : MonoBehaviour
    {
        public UnityEvent ScoreUpdate;
        private const string HIGHSCORE_STRING_KEY = "highscore_key";
        [SerializeField]
        private GameObject birdPrefab;
        [SerializeField]
        private ObjectPoolManager obstacleManager;
        [SerializeField]
        private ObjectPoolManager backgroundManager;
        [SerializeField]
        private UiManager _uiManager;

        public void StartGame()
        {
            gameOver = false;
            _bird.StartMove();
            obstacleManager.StartMove();
            backgroundManager.StartMove();
            _uiManager.StartGame();
        }
        public void RestartGame()
        {
            gameOver = false;
            _bird.StartMove();
            obstacleManager.StartMove();
            backgroundManager.StartMove();
            _uiManager.StartGame();
            _profile.score = 0;
            _bird.ResetTransform();
        }

        public bool gameOver { get; private set; }
        public Profile _profile { get; private set; }
        private Bird _bird;
        private void Awake()
        {
            var birdGo = Instantiate(birdPrefab);
            ScoreUpdate = new UnityEvent();
            _bird = birdGo.GetComponent<Bird>();
            _bird.Init(this);
            _bird.transform.SetParent(transform, false);
            obstacleManager.Init();
            backgroundManager.Init();
            _uiManager.Init();
            _profile = new Profile();
            _profile.score = 0;
            _profile.highscore = PlayerPrefs.GetInt(HIGHSCORE_STRING_KEY, 0);
        }

        public void GameOver()
        {
            Debug.Log("Game Over");
            _bird.StopMove();
            obstacleManager.StopMove();
            backgroundManager.StopMove();
            _uiManager.GameOver();
            gameOver = true;
        }

        public void CollectCoin()
        {
            _profile.score++;
            ScoreUpdate.Invoke();
            if (_profile.score > _profile.highscore)
            {
                _profile.highscore = _profile.score;
                PlayerPrefs.SetInt(HIGHSCORE_STRING_KEY, _profile.score);
            }
        }
    }
}
