using System;

namespace unit04_greed
{
    class FallingObject : Actor
    {
        Actor _actor;
        
        public FallingObject(Actor actor)
        {
            _actor = actor;
        }
        position = 
        public FallingObject()
        {

        }
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