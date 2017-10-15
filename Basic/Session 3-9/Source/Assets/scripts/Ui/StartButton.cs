namespace FlappyBird
{
    using UnityEngine;
    using UnityEngine.UI;
    public class StartButton : GameButton
    {
        protected override void Pressed()
        {
            base.Pressed();
            _gameManager.StartGame();
        }
    }
}
