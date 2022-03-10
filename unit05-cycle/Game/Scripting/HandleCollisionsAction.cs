using System;
using System.Collections.Generic;
using System.Data;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An update action that handles interactions between the actors.</para>
    /// <para>
    /// The responsibility of HandleCollisionsAction is to handle the situation when the snake 
    /// collides with the food, or the snake collides with its segments, or the game is over.
    /// </para>
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        private bool isGameOver = false;

        /// <summary>
        /// Constructs a new instance of HandleCollisionsAction.
        /// </summary>
        public HandleCollisionsAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            if (isGameOver == false)
            {
                //HandleFoodCollisions(cast);
                HandleSegmentCollisions(cast);
                HandleGameOver(cast);
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleFoodCollisions(Cast cast)
        {
            Snake snake = (Snake)cast.GetFirstActor("snake");
            
        }

        /// <summary>
        /// Sets the game over flag if the snake collides with one of its segments.
        /// </summary>
        /// <param name="cast">The cast of actors.</param>
        private void HandleSegmentCollisions(Cast cast)
        {
            //Snake snake = (Snake)cast.GetFirstActor("snake");
            List<Actor> actors = cast.GetActors("snake");
            List<Snake> snakes = new List<Snake>();
            foreach (Actor actor in actors)
            {
                snakes.Add((Snake)actor);
            }
            List<Actor> heads = new List<Actor>();
            List<Actor> segments = new List<Actor>();
            foreach (Snake snake in snakes)
            {
                Actor head = snake.GetHead();
                heads.Add(head);

                List<Actor> body = snake.GetBody();
                foreach (Actor segment in body)
                {
                    segments.Add(segment);
                }
            }

            foreach (Actor segment in segments)
                {
                    foreach (Actor head in heads)
                    {
                        if (segment.GetPosition().Equals(head.GetPosition()))
                        {
                            isGameOver = true;
                        }
                    }                    
                }            
        }

        private void HandleGameOver(Cast cast)
        {
            if (isGameOver == true)
            {
                
                
                List<Actor> snakes = cast.GetActors("snake");
                foreach (Actor actor in snakes)
                {
                    snakes.Add((Snake)actor);
                    
                }
                
                Snake snake = (Snake)cast.GetFirstActor("snake");
                List<Actor> segments = snake.GetSegments();
                //Food food = (Food)cast.GetFirstActor("food");

                // create a "game over" message
                int x = Constants.MAX_X / 2;
                int y = Constants.MAX_Y / 2;
                Point position = new Point(x, y);

                Actor message = new Actor();
                message.SetText("Game Over!");
                message.SetPosition(position);
                cast.AddActor("messages", message);

                // make everything white
                foreach (Actor segment in segments)
                {
                    segment.SetColor(Constants.WHITE);
                }
                //food.SetColor(Constants.WHITE);
            }
        }

    }
}