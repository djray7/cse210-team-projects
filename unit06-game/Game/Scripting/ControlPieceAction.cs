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
            List<Actor> pieces = cast.GetActors(Constants.PIECE_GROUP);
            //Pieces bricks = (Pieces)cast.GetFirstActor(Constants.BRICK_GROUP);
            if (MouseService.IsButtonPressed("left"))
            {
                if (cast.IsAnyPieceSelected())
                {
                    // we already have one selected to move
                    // we should look for squares now, and move the piece there
                    // then don't forget to deselect the piece at that point

                    Piece piece = cast.FindSelectedPiece();

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
                    
                    foreach (Actor actor in pieces)
                    {
                        Piece piece = (Piece)actor;
                        Body pieceBody = piece.GetBody();

                        Point mouseCoordinates = MouseService.GetCoordinates();
                        Point pieceCoordinates = pieceBody.GetPosition();
                        
                        if (brick.IsOverlapping(mouseCoordinates))
                        {
                            piece.SelectPiece();
                            Console.WriteLine($"Found {piece}");
                        }
                    }

                }                
            } // end of is mouse clicked
        }
    }
}