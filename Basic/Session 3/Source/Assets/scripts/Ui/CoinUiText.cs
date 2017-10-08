namespace FlappyBird
{
    using System;
    using UnityEngine.Assertions;
    using UnityEngine.UI;

    public class CoinUiText : UiText
    {
        protected override void Awake()
        {
            base.Awake();
            _gameManager.ScoreUpdate.AddListener(UpdateText);
        }

        void OnEnable()
        {
            UpdateText();
        }

        private void UpdateText()
        {
            Assert.IsNotNull(_textComponent, "textcomponent is not set");
            _textComponent.text = _gameManager._profile.score.ToString();
        }
    }
}
