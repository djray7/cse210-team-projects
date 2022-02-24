using System;

namespace unit04_greed
{
    class FallingObject : Actor
    {
        public void MoveNext()
        {
            int x = ((position.GetX() + velocity.GetX()));
            int y = ((position.GetY() + velocity.GetY()));
            position = new Point(x, y);
        }
    }
}