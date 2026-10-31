namespace CarGame
{
    public abstract class Car
    {
        protected int x;
        protected float y;

        public int X
        {
            get { return x; }
        }

        public float Y
        {
            get { return y; }
        }

        public Car(int startX, float startY)
        {
            x = startX;
            y = startY;
        }

        public abstract void Move();
    }
}
