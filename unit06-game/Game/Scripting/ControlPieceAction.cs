using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class ControlPieceAction //: Action
    {
        private MouseService MouseService;
        private Brick _brick;

        public ControlPieceAction(MouseService mouseService)
        {
            this.MouseService = mouseService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            Mouse mouse = (Mouse)cast.GetFirstActor(Constants.MOUSE_GROUP);
            List<Actor> bricks = cast.GetActors(Constants.BRICK_GROUP);
            //Pieces bricks = (Pieces)cast.GetFirstActor(Constants.BRICK_GROUP);
            if (MouseService.IsButtonPressed(Constants.CLICK))
            {
                foreach (Actor actor in bricks)
                {
                    Brick brick = (Brick)actor;
                    Body brickBody = brick.GetBody();
                    Point MouseCoordinates = MouseService.GetCoordinates();
                    if (MouseCoordinates.Equals(brickBody.GetPosition()))
                    {
                        _brick = brick;
                    }                    
                }                
            }
            if (MouseService.IsButtonReleased(Constants.CLICK)){
                Point MouseCoordinates = MouseService.GetCoordinates();
                Body brickBody = _brick.GetBody();
                brickBody.SetPosition(MouseCoordinates);
            }
        }
    }
}