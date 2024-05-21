using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JyankenGame.Model
{
    public class JyankenScore
    {
        private int _winScore = 0;
        private int _allScore = 0;

        public void SetRecord (int winScore)
        {
            _winScore += winScore;
            _allScore += 1;
        }

        public int GetWinScore ()
        {
            return _winScore;
        }

        public int GetAllScore ()
        {
            return _allScore;
        }
    }
}
