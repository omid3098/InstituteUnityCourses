namespace FlappyBird
{
    using UnityEngine;
    using UnityEngine.Assertions;
    using UnityEngine.Events;
    using UnityEngine.UI;
    public class UiText : MonoBehaviour
    {
        protected Text _textComponent;
        protected GameManager _gameManager;

        protected virtual void Awake()
        {
            _gameManager = FindObjectOfType<GameManager>();
            _textComponent = GetComponent<Text>();
        }
    }
}
