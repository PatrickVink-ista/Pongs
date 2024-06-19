#nullable disable
using Pongs;
using PongsSBK;
using System.Windows.Shapes;

public static class GameExtensions
{
    public static void DrawPaddle(this Player player, PongsGameSBK game, Rectangle paddle)
    {
        game.DrawPaddle(paddle, player.Paddle.X, player.Paddle.Y);
    }
}