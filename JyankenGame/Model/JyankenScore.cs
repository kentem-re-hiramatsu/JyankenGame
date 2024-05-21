using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JyankenGame.Model
{
    public class JyankenScore
    {
        private int _winRecord = 0;
        private int _LoseRecord = 0;

        public void SetRecord (int winRecord, int loseRecord)
        {
            _winRecord = winRecord;
            _LoseRecord=loseRecord;
        }

        public int GetRecord ()
        {
            return _winRecord;
        }

        public int GetLoseRecord ()
        {
            return _LoseRecord;
        }
    }
}
