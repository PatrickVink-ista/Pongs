#nullable disable
using PongsSBK;
using System.Windows.Shapes;

namespace Pongs
{
    public static class GameExtensions
    {
        public static void DrawPaddle(this Player player, PongsGameSBK game, Rectangle paddle)
        {
            game.DrawPaddle(paddle, player.Paddle.X, player.Paddle.Y);
        }
    }
}