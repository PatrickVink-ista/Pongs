using System.Windows.Media;

namespace PongsSBK
{
    public class SliderInfo
    {
        public const double BALL_MAX_SPEED = 10.0;
        public const double PADDLE_MAX_SPEED = 10.0;


        public SliderInfo(SBKPongEngine engine)
        {
            Engine = engine;

        }
        public static double BallSpeed { get; set; }
        public static double BallSize { get; set; }
        public static double PaddleSpeed { get; set; }
        public static double PaddleSize { get; set; }
        public static double RoundsToWin { get; set; }
        public static Color BallColor { get; set; }
        public static Color BackgroundColor { get; set; }
        public static Color PaddleColor { get; set; }
        public static Color WallColor { get; set; }

        public SBKPongEngine Engine { get; private set; }
    }
}