using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class ControlPieceAction //: Action
    {
        private MouseService MouseService;

        public ControlPieceAction(MouseService mouseService)
        {
            this.MouseService = mouseService;
        }

        // public void Execute(Cast cast, Script script, ActionCallback callback)
        // {
            // List<Actor> brick = cast.GetActors(Constants.BRICK_GROUP);
            // Pieces racket = (Pieces)cast.GetFirstActor(Constants.BRICK_GROUP);
            // if (MouseService.IsButtonDown(Constants.CLICK));
            // {
            //     foreach (Actor actor in brick)
            //     {
            //         Brick brick = (Brick)actor;
            //         Body brickBody = brick.GetBody();
            //         MouseService = mouse.GetBody();
            //     }
                
            // }
            // else if (MouseService.IsButtonDown(Constants.RIGHT))
            // {
            //     Mouse mouse = new Mouse());
            //     Body mousebody = mouse.GetPosition();
            //     racket.MoveNext();
            // }
            // else
            // {
            //     racket.StopMoving();
            // }
        //}
    }
}