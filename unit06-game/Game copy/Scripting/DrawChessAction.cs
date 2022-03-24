using Unit06.Game.Casting;
using Unit06.Game.Services;


namespace Unit06.Game.Scripting
{
    public class DrawChessAction //: Action
    {
        private VideoService videoService;
        
        public DrawChessAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        // public void Execute(Cast cast, Script script, ActionCallback callback)
        // {
        //     Body body = new Body(new Point(4,6), new Point (94,6), new Point (0,0));
        //     ChessPlayers chess = (ChessPlayers)cast.GetFirstActor(Constants.CHESS_GROUP);
        //     body = chess.GetBody();

        //     if (chess.IsDebug())
        //     {
        //         Rectangle rectangle = body.GetRectangle();
        //         Point size = rectangle.GetSize();
        //         Point pos = rectangle.GetPosition();
        //         videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
        //     }

        //     Image image = chess.GetImage();
        //     Point position = body.GetPosition();
        //     videoService.DrawImage(image, position);
        // }
    }
}