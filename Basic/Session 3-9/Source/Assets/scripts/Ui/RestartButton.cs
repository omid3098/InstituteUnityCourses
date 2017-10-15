namespace FlappyBird
{
    public class RestartButton : GameButton
    {
        protected override void Pressed()
        {
            base.Pressed();
            _gameManager.RestartGame();
        }
    }
}
