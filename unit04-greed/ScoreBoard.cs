using System;

namespace unit04_greed
{
    class ScoreBoard : Actor
    {
        private int _score; 
        public ScoreBoard()
        {

        }
        public int GetScore(int score)
        {
            _score = score;
            return _score;

        }


    }
}