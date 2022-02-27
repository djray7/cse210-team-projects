using System;
using System.Collections.Generic;
using unit04_greed.Services;
//using unit04-greed.Services;


namespace unit04_greed
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private KeyboardService keyboardService = null;
        private VideoService videoService = null;
        private static int FONT_SIZE = 15;
        
        private int _score = 0;
        /// <summary>
        /// Constructs a new instance of Director using the given KeyboardService and VideoService.
        /// </summary>
        /// <param name="keyboardService">The given KeyboardService.</param>
        /// <param name="videoService">The given VideoService.</param>

        public void Collissions()
        {
            return;
        }

        public Director(KeyboardService keyboardService, VideoService videoService)
        {
            this.keyboardService = keyboardService;
            this.videoService = videoService;
        }

        /// <summary>
        /// Starts the game by running the main game loop for the given cast.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        public void StartGame(Cast cast)
        {
            videoService.OpenWindow();
            while (videoService.IsWindowOpen())
            {
                GetInputs(cast);
                DoUpdates(cast);
                DoOutputs(cast);
            }
            videoService.CloseWindow();
        }

        /// <summary>
        /// Gets directional input from the keyboard and applies it to the robot.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void GetInputs(Cast cast)
        {
            Actor robot = cast.GetFirstActor("robot");
            Point velocity = keyboardService.GetDirection("dontMove");
            robot.SetVelocity(velocity);

            
            Random random = new Random();
            int x = random.Next(1, 890);

            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            Color color = new Color(r, g, b);
            FallingObject falling = new FallingObject();
            falling.SetText("O");
            falling.SetFontSize(FONT_SIZE);
            falling.SetColor(color);
            falling.SetPosition(new Point(x,0));
            Point velocityF = keyboardService.GetDirection("down");
            
            int max = videoService.GetWidth();
            int may = videoService.GetHeight();
            robot.MoveNext(max, may);
           
            //Point velocityFall = keyboardService.GetDirection("down");
            //falling.SetVelocityF(velocityFall);

            cast.AddActor("falling", falling);

            //Point velocityF = keyboardService.GetDirection("down");
            //falling.SetVelocity(VelocityF)
            
            

    

        }

        /// <summary>
        /// Updates the robot's position and resolves any collisions with artifacts.
        /// </summary>
        /// <param name="cast">The given cast.</param>
        private void DoUpdates(Cast cast)
        {
            Actor banner = cast.GetFirstActor("banner");
            ScoreBoard bannerScore = new ScoreBoard();
            _score = bannerScore.UpdateScore(_score);
            banner.SetText($"Score: {_score}" );

            // this code will be for adding to the score board.
            //if colide then _score = _score + add or subtract  
            //_score = _score + 10;

            Actor robot = cast.GetFirstActor("robot");

            //Actor falling = cast.GetFirstActor("falling");
            Actor falling = cast.GetFirstActor("falling");

            int max = videoService.GetWidth();
            int may = videoService.GetHeight();
            robot.MoveNext(max, may);
            
            falling.MoveNext(max, may);

            if (robot.GetPosition() == (falling.GetPosition()))
            {
                _score = bannerScore.UpdateScore(_score);
            }

            //List<Actor> fallings = cast.GetActors("falling");
            //foreach (Actor actor in fallings)
            //{
            //    
            //    if (robot.GetPosition().Equals(falling.GetPosition()))
            //    {
            //        _score = _score + 10;
            //    }
            //} 


            //Actor fall = cast.GetFirstActor("fall");
            //fall.SetVelocity(new Point(0, 20));
            //FallingObject fo = new FallingObject(fall);
            //fo.MoveNext();

            // fall = fo.GetActor();
            // cast.AddActor("fall", fall);
        }

        /// <summary>
        /// Draws the actors on the screen.
        /// </summary>
        /// <param name="cast">The given cast.</param>


        public void DoOutputs(Cast cast)
        {
            List<Actor> actors = cast.GetAllActors();
            videoService.ClearBuffer();
            videoService.DrawActors(actors);
            videoService.FlushBuffer();
        }


    }
}