using JyankenGame.Constant;
using JyankenGame.Enum;
using JyankenGame.Model;

namespace JyankenGame.Controller
{
    public class JyankenManager
    {
        private int _userJyanken;
        private int _enemyJyanken;

        JyankenScore jyankenScore = new JyankenScore();

        public int GetUserJyanken () { return _userJyanken; }
        public int GetEnemyJyanken () { return _enemyJyanken; }

        public void SetJyanken(int type)
        {
            _userJyanken = 0;

            while (true)
            {
                if(type >= (int)JyankenTypeEnum.JyankenType.グー && (type <= (int)JyankenTypeEnum.JyankenType.パー))
                {
                    _userJyanken = type;
                    SetEnemyJyanken();
                    return;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        private void SetEnemyJyanken()
        {
            Random random = new Random();

            int randamJyankenType = random.Next(0,3);

            _enemyJyanken = randamJyankenType;
        }

        public JyankenTypeEnum.JyankenType GetHandName(int handType)
        {
            switch (handType)
            {
                case (int)JyankenTypeEnum.JyankenType.グー:
                    return JyankenTypeEnum.JyankenType.グー;

                case (int)JyankenTypeEnum.JyankenType.チョキ:
                    return JyankenTypeEnum.JyankenType.チョキ;

                case (int)JyankenTypeEnum.JyankenType.パー:
                    return JyankenTypeEnum.JyankenType.パー;

                default:
                    return 0;
            }
        }

        public string WinLoseJuge()
        {
            int userJyanken = _userJyanken;
            int enemyJyanken = _enemyJyanken;
            int juge = (userJyanken - enemyJyanken + 3) % 3;

            if (juge == 0)
            {
                jyankenScore.SetRecord(false);
                return Constans.PLAYER_DRAW_MESSAGE;
            }

            if(juge == 2)
            {
                jyankenScore.SetRecord(true);
                return Constans.PLAYER_WIN_MESSAGE;
            }
            else
            {
                jyankenScore.SetRecord(false);
                return Constans.PLAYER_LOSE_MESSAGE;
            }
        }

        public double ShowOverAllScores()
        {
            double winScore = jyankenScore.GetWinScore();
            double allScore = jyankenScore.GetAllScore();
            double winRate = Math.Round((winScore / allScore) * 100 ,2);

            return winRate;
        }
    }
}
