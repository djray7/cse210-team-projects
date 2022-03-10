using System;
using System.Collections.Generic;
using System.Linq;


namespace Unit05.Game.Casting
{
    /// <summary>
    /// <para>A tasty item that snakes like to eat.</para>
    /// <para>
    /// The responsibility of Food is to select a random position and points that it's worth.
    /// </para>
    /// </summary>
    public class Player : Actor
    {

        /// <summary>
        /// Constructs a new instance of an Food.
        /// </summary>
        protected List<Actor> segments = new List<Actor>();
        public Player(int player, int numberPoint)
        {
            AddPoints(numberPoint, player);
           
        }

        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddPoints(int points, int player)
        {
            Point position = new Point(points, 300);
            Actor segment = new Actor();
            segment.SetPosition(position);
            segment.SetText($"player {player}");
            segments.Add(segment);
            

        }
    }
}