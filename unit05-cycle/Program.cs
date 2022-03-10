using Unit05.Game.Casting;
using Unit05.Game.Directing;
using Unit05.Game.Scripting;
using Unit05.Game.Services;
using Unit05.Game;


namespace Unit05
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            // create the cast
            Cast cast = new Cast();

            //cast.AddActor("food", new Food());
            cast.AddActor("snake", new Snake(300, Constants.RED, Constants.YELLOW));
            cast.AddActor("snake", new Snake(600, Constants.WHITE, Constants.GREEN));
            cast.AddActor("player1", new Player(1, 0));
            cast.AddActor("player2", new Player(2, 830));

            // create the services
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);
           
            //Director director = new Director(videoService);
            // create the script
            Script script = new Script();
            //script.AddAction("input", new ControlActorsAction(keyboardService, director));
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            // start the game
            Director director = new Director(videoService);
            director.StartGame(cast, script);
            // bool isRDown = false;
            // do
            // {
            //     isRDown = false;
            //     isRDown = director.StartGame(cast, script, keyboardService);
            //     if (isRDown == false)
            //     {
            //         break;
            //     }
            // } while (isRDown);          
        }
    }
}