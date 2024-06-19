namespace PongsSBK
{
    public struct Paddle
    {
        public Paddle(double x = 0, double y = 0)
        {
            X = x; Y = y;
        }
        public double X { get; private set; }
        public double Y { get; private set; }
        public void IncrementX(double value) => X += value;
        public void IncrementY(double value) => Y += value;
        public void Set(double x, double y) { X = x; Y = y; }
    }
}
