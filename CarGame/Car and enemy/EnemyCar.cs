namespace CarGame
{
    public class EnemyCar : Car
    {
        private float speed;

        public EnemyCar(int x, float y, float speed)
            : base(x, y)
        {
            this.speed = speed;
        }

        public override void Move()
        {
            y += speed;
        }
    }
}
