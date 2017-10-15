namespace FlappyBird
{
    using UnityEngine;
    using UnityEngine.UI;
    public class GameButton : MonoBehaviour
    {
        private Button button;
        protected GameManager _gameManager;

        void Awake()
        {
            button = GetComponent<Button>();
            _gameManager = FindObjectOfType<GameManager>();
            button.onClick.AddListener(Pressed);
        }

        protected virtual void Pressed()
        {
        }
    }
}
