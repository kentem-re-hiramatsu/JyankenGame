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
        private int _allRecord = 0;

        public void SetRecord (int winRecord)
        {
            _winRecord += winRecord;
            _allRecord += 1;
        }

        public int GetWinRecord ()
        {
            return _winRecord;
        }

        public int GetAllRecord ()
        {
            return _allRecord;
        }
    }
}
