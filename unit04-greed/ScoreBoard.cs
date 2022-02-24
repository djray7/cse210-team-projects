using System;

namespace unit04_greed
{
    class ScoreBoard : Actor
    {
        private int _score; 
        public ScoreBoard()
        {

        }
    
        public int UpdateScore(int newScore)
        {
            _score = _score + newScore;
            return _score;
        }


    }
}