using System;
using System.Collections.Generic;


namespace Unit06.Game.Casting
{
    public class Square : Actor
    {
        private string text = "";
        private int fontSize = 15;
        private Color color = new Color(255, 255, 255); // white
        protected Point position = new Point(0, 0);

        public Square(bool debug) : base(debug)
        {

        }
    }
}