namespace FlappyBird
{
    using UnityEngine;
    using UnityEngine.UI;

    public class CoinUiText : MonoBehaviour
    {
        private GameManager _gameManager;
        private Text _textComponent;

        public void Init(GameManager _gm)
        {
            _gameManager = _gm;
            _textComponent = GetComponent<Text>();
        }

        void Update()
        {
            _textComponent.text = "coin: " + _gameManager._profile.score;
        }
    }
}
