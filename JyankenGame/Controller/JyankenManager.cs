using JyankenGame.Constant;
using JyankenGame.Enum;
using JyankenGame.Model;

namespace JyankenGame.Controller
{
    public class JyankenManager
    {
        private int _userJyanken;

        JyankenScore jyankenScore = new JyankenScore();

        public void GetUserJyanken(int type)
        {
            _userJyanken = 0;

            while (true)
            {
                if(type >= (int)JyankenTypeEnum.JyankenType.グー && (type <= (int)JyankenTypeEnum.JyankenType.パー))
                {
                    _userJyanken = type;
                    return;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        private int GetEnemyJyanken()
        {
            Random random = new Random();

            int randamJyankenType = random.Next(0,3);

            return randamJyankenType;
        }

        private JyankenTypeEnum.JyankenType GetHandName(int handType)
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

        public void ShowWinLoseJuge()
        {
            int userJyanken = _userJyanken;
            int enemyJyanken = GetEnemyJyanken();

            int juge = (userJyanken - enemyJyanken + 3) % 3;

            JyankenTypeEnum.JyankenType userJyankenType = GetHandName(userJyanken);
            JyankenTypeEnum.JyankenType enemyJyankenType = GetHandName(enemyJyanken);

            if (juge == 0)
            {
                jyankenScore.SetRecord(false);
                Console.WriteLine(Constans.PLAYER_DRAW_MESSAGE,userJyankenType,enemyJyankenType);
            }
            else if(juge == 2)
            {
                jyankenScore.SetRecord(true);
                Console.WriteLine(Constans.PLAYER_WIN_MESSAGE,userJyankenType,enemyJyankenType);
            }
            else
            {
                jyankenScore.SetRecord(false);
                Console.WriteLine(Constans.PLAYER_LOSE_MESSAGE,userJyankenType,enemyJyankenType);
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
