namespace FlappyBird
{
    using System;
    using UnityEngine;
    public class UiManager : MonoBehaviour
    {
        public GameObject score_panel;
        public GameObject gameover_panel;
        public GameObject start_panel;

        public void Init()
        {
            score_panel.SetActive(false);
            start_panel.SetActive(true);
            gameover_panel.SetActive(false);
        }

        public void StartGame()
        {
            score_panel.SetActive(true);
            start_panel.SetActive(false);
            gameover_panel.SetActive(false);
        }

        public void GameOver()
        {
            score_panel.SetActive(false);
            start_panel.SetActive(false);
            gameover_panel.SetActive(true);
        }
    }
}
