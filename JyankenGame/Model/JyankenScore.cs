namespace JyankenGame.Model
{
    public class JyankenScore
    {
        private int _winScore = 0;
        private int _allScore = 0;

        public void SetRecord (bool isWin)
        {
            if (isWin)
            {
                _winScore += 1;
            }
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
