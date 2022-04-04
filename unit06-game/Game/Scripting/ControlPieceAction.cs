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
            List<Actor> bricks = cast.GetActors(Constants.BRICK_GROUP);
            if (MouseService.IsButtonPressed("left"))
            {
                if (cast.IsAnyPieceSelected())
                {
                    selectBrick(mouse, bricks);
                    movePiece(cast, mouse);
                    //collision(cast);
                }
                else
                {
                    selectPiece(mouse, pieces);
                }                               
            } // end of is mouse clicked
        }

        public void selectPiece(Mouse mouse, List<Actor> pieces)
        {
            foreach (Actor actor in pieces)
            {
                Piece piece = (Piece)actor;
                Body pieceBody = piece.GetBody();

                Point mouseCoordinates = MouseService.GetCoordinates();
                Point pieceCoordinates = pieceBody.GetPosition();
                
                if (mouseCoordinates.GetX() > pieceCoordinates.GetX()
                    && mouseCoordinates.GetX() < pieceCoordinates.GetX() + Constants.PIECE_WIDTH
                    && mouseCoordinates.GetY() > pieceCoordinates.GetY() 
                    && mouseCoordinates.GetY() < pieceCoordinates.GetY() + Constants.PIECE_HEIGHT)
                {
                    piece.SelectPiece();
                    Console.WriteLine($"Found {piece}");
                }
            }
        }

        public void selectBrick(Mouse mouse, List<Actor> bricks)
        {
            foreach (Actor actor in bricks)
            {
                Brick brick = (Brick)actor;
                Body brickBody = brick.GetBody();

                Point mouseCoordinates = MouseService.GetCoordinates();
                Point brickCoordinates = brickBody.GetPosition();
                
                if (mouseCoordinates.GetX() > brickCoordinates.GetX()
                    && mouseCoordinates.GetX() < brickCoordinates.GetX() + Constants.BRICK_WIDTH
                    && mouseCoordinates.GetY() > brickCoordinates.GetY() 
                    && mouseCoordinates.GetY() < brickCoordinates.GetY() + Constants.BRICK_HEIGHT)
                {
                    brick.SelectPiece();
                    Console.WriteLine($"Found {brick}");
                }
            }
        }

        public void movePiece(Cast cast, Mouse mouse)
        {            
            foreach(Piece piece in cast.GetActors(Constants.PIECE_GROUP))
            {
                if (piece.IsSelected())
                {
                    foreach(Brick brick in cast.GetActors(Constants.BRICK_GROUP))
                    {
                        if (brick.IsSelected())
                        {
                            piece.GetBody().SetPosition(brick.GetBody().GetPosition());
                            piece.DeselectPiece();
                            brick.DeselectPiece();
                        }
                    }
                }
            }

            // if (cast.IsAnyPieceSelected())
            // {
            //     // we already have one selected to move
            //     // we should look for squares now, and move the piece there
            //     // then don't forget to deselect the piece at that point

            //     Piece piece = cast.FindSelectedPiece();

            //     // foreach (Square square in cast.GetActors(Constants.SQAURE_GROUP))
            //     // {

            //     // }
            // }
            // else
            // {
            //     // we have not selected a piece at this point
            //     // we should look through all the pieces in the piece group
            //     // and see if the mouse overlaps any of them.
            //     // If it does, we'll select that one.
                
            //     foreach (Actor actor in pieces)
            //     {
            //         Piece piece = (Piece)actor;
            //         Body pieceBody = piece.GetBody();

            //         Point mouseCoordinates = MouseService.GetCoordinates();
            //         Point pieceCoordinates = pieceBody.GetPosition();
                    
            //         if (mouseCoordinates.GetX() > pieceCoordinates.GetX()
            //             && mouseCoordinates.GetX() < pieceCoordinates.GetX() + Constants.PIECE_WIDTH
            //             && mouseCoordinates.GetY() > pieceCoordinates.GetY() 
            //             && mouseCoordinates.GetY() < pieceCoordinates.GetY() + Constants.PIECE_HEIGHT)
            //         {
            //             piece.SelectPiece();
            //             Console.WriteLine($"Found {piece}");
            //         }
            //     }

            // }
        }

        public void Collision(Cast cast)
        {
            List<Point> positions = new List<Point>();
            foreach (Actor actor in cast)
            {
                Point position = actor.GetBody().GetPosition();
                positions.Add(position);                
            }
            for (int i = 0; i < positions.Count; i++)
            {
                print();
            }
        }
    }
}