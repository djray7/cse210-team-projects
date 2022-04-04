using System;
using System.Collections.Generic;
using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class ControlPieceAction : Action
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
            if (MouseService.IsButtonPressed("left"))
            {
                if (cast.IsAnyPieceSelected())
                {
                    // we already have one selected to move
                    // we should look for squares now, and move the piece there
                    // then don't forget to deselect the piece at that point

                    Brick piece = cast.FindSelectedPiece();

                    // foreach (Square square in cast.GetActors(Constants.SQAURE_GROUP))
                    // {

                    // }
                }
                else
                {
                    // we have not selected a piece at this point
                    // we should look through all the pieces in the piece group
                    // and see if the mouse overlaps any of them.
                    // If it does, we'll select that one.
                    
                    foreach (Actor actor in bricks)
                    {
                        Brick brick = (Brick)actor;

                        Point mouseCoordinates = MouseService.GetCoordinates();
                        
                        if (brick.IsOverlapping(mouseCoordinates))
                        {
                            brick.SelectPiece();
                            Console.WriteLine("Found something!");
                        }
                    }

                }                
            } // end of is mouse clicked
        }
    }
}