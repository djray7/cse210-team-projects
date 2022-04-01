using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class ControlPieceAction //: Action
    {
        private MouseService MouseService;
        private PhysicsService physicsService;
        private Body pieceActor;

        // public ControlPieceAction(MouseService mouseService, PhysicsService physicsService)
        // {
        //     this.MouseService = mouseService;
        //     this.physicsService= physicsService;
        // }

        // public void Execute(Cast cast, Script script, ActionCallback callback)
        // {
        //     //Mouse mouse = new Mouse();
        //     List<Actor> brick = cast.GetActors(Constants.BRICK_GROUP);
        //     Brick bricks = (Brick)cast.GetFirstActor(Constants.BRICK_GROUP);
        //     Point MouseCoordinates = MouseService.GetCoordinates();
        //     Mouse mouse = (Mouse)cast.GetFirstActor(Constants.MOUSE_GROUP);
        //     Brick piece = (Brick)cast.GetFirstActor(Constants.BRICK_GROUP);
            

        //     if (MouseService.IsButtonPressed(Constants.CLICK));
        //     {
        //         // if ()
        //         // {
        //             // to do a list 
        //         // }
        //         Body mouseBody = mouse.GetBody();
        //         Body brickBody = piece.GetBody();
                
        //         foreach (Actor actor in brick)
        //         {


        //             if (physicsService.HasCollided(mouseBody, brickBody))
        //             {
        //                 pieceActor = brickBody;
        //             }

        //         }
                
        //     }
        //     if (MouseService.IsButtonPressed(Constants.CLICK))
        //     {
        //         //pieceActor = mouseBody;
        //     }
        //     else
        //     {
        //         bricks.StopMoving();
        //     }
        // }
    }
}