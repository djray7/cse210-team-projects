using System;

namespace unit04_greed
{
    class FallingObject : Actor
    {
        Actor _actor;
        Point _velocity;

        public FallingObject()
        {
            // _velocity = (0, 1);
            _actor = actor;
        }
        // public FallingObject()
        // {

        // }
        public void MoveNext()
        {
            int x = ((position.GetX() + velocity.GetX()));
            int y = ((position.GetY() + velocity.GetY()));
            position = new Point(x, y);
        }
        public Actor GetActor()
        {
            return _actor;
        }
    }
}