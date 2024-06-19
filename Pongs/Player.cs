namespace PongsSBK
{
    public class Player
    {
        public Player(string name, Paddle? paddle, bool isBot = false)
        {
            Name = name;
            IsBot = isBot;
            Paddle = paddle ?? new Paddle();
            x = Paddle.X;
            y = Paddle.Y;
        }
        private double x;
        private double y;
        public bool IsBot { get; private set; }
        public bool IsHuman => !IsBot;
        public bool HasWon { get; private set; }
        public string Name { get; private set; }
        public Paddle Paddle { get; private set; }
        public int Score { get; private set; } = 0;
        public void IncrementScore(double roundsToWin)
        {
            Score += 1;
            if (Score == roundsToWin)
                Win();
        }
        public void Reset() 
        {
            HasWon = false;
            Score = 0;
            Paddle.Set(x, y);
        }
        public void Win()
        {
            HasWon = true;
        }
    }
}
