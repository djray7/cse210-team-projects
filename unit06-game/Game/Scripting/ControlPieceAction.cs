using System.Collections.Generic;
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
        //     Mouse mouse = new Mouse();
        //     List<Actor> brick = cast.GetActors(Constants.BRICK_GROUP);
        //     Pieces bricks = (Pieces)cast.GetFirstActor(Constants.BRICK_GROUP);
        //     if (MouseService.IsButtonDown(Constants.CLICK));
        //     {
        //         foreach (Actor actor in brick)
        //         {
        //             Brick brick = (Brick)actor;
        //             Body brickBody = brick.GetBody();
        //             Point MouseCoordinates = MouseService.GetCoordinates();
        //         }
                
        //     }
        //     if (MouseService.IsButtonDown(Constants.CLICK))
        //     {
        //         Body mousebody = mouse.GetPosition();
        //         bricks.MoveNext();
        //     }
        //     else
        //     {
        //         bricks.StopMoving();
        //     }
        // }
    }
}