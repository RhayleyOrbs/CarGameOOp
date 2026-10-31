namespace CarGame
{
    public class PlayerCar : Car
    {
        private int targetX;
        private float targetY;
        private int laneSpeed;
        private float forwardSpeed;

        public PlayerCar(int x, float y)
            : base(x, y)
        {
            targetX = x;
            targetY = y;
        }

        public void SetTarget(
            int newX, float newY,
            int horizontalSpeed, float verticalSpeed)
        {
            targetX = newX;
            targetY = newY;
            laneSpeed = horizontalSpeed;
            forwardSpeed = verticalSpeed;
        }

        public override void Move()
        {
            if (x < targetX)
                x = System.Math.Min(x + laneSpeed, targetX);
            else if (x > targetX)
                x = System.Math.Max(x - laneSpeed, targetX);

            if (y < targetY)
                y = System.Math.Min(y + forwardSpeed, targetY);
            else if (y > targetY)
                y = System.Math.Max(y - forwardSpeed, targetY);
        }
    }
}
