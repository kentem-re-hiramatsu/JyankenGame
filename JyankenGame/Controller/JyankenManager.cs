using JyankenGame.Constant;
using JyankenGame.Enum;
using JyankenGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JyankenGame.Controller
{
    public class JyankenManager
    {
        private int _userHandSignal;

        JyankenScore jyankenScore = new JyankenScore();

        public void GetHandSignal(int type)
        {
            _userHandSignal = 0;

            while (true)
            {
                if((int)type >= 1 && (int)type <= 3)
                {
                    _userHandSignal = type;
                }
                else
                {
                    Console.WriteLine(Constans.HANDSIGNAL_ERROR_MESSAGE);
                }
            }
        }

        public int GetEnemyHandSignal()
        {
            Random random = new Random();

            int randamHandSignal = random.Next(0,3);

            return randamHandSignal;
        }

        public JyankenTypeEnum.JyankenType GetHandName(int handType)
        {
            if (handType == (int)JyankenTypeEnum.JyankenType.グー)
            {
                return JyankenTypeEnum.JyankenType.グー;
            }
            else if (handType == (int)JyankenTypeEnum.JyankenType.チョキ)
            {
                return JyankenTypeEnum.JyankenType.チョキ;
            }
            else
            {
                return JyankenTypeEnum.JyankenType.パー;
            }
        }

        public void ShowWinLoseJuge()
        {
            int userHandSignal = _userHandSignal;
            int enemyHandSignal = GetEnemyHandSignal();

            int juge = (userHandSignal - enemyHandSignal + 3) % 3;

            JyankenTypeEnum.JyankenType userJyankenType = GetHandName(userHandSignal);
            JyankenTypeEnum.JyankenType enemyJyankenType = GetHandName(enemyHandSignal);

            if (juge == 0)
            {
                jyankenScore.SetRecord(1, 0);
                Console.WriteLine(Constans.PLAYER_DRAW_MESSAGE,userJyankenType,enemyJyankenType);
            }
            else if(juge == 2)
            {
                jyankenScore.SetRecord(0,1);
                Console.WriteLine(Constans.PLAYER_WIN_MESSAGE,userJyankenType,enemyJyankenType);
            }
            else
            {
                Console.WriteLine(Constans.PLAYER_LOSE_MESSAGE,userJyankenType,enemyJyankenType);
            }
        }

        public void ShowOverAllScores()
        {
            var winScore = jyankenScore.GetWinRecord();
            var loseScore = jyankenScore.GetLoseRecord();
            var allScore = (loseScore / winScore) * 100;

            Console.WriteLine(Constans.PLAYER_OVER_ALL_SCORE_MESSAGE,allScore);
        }
    }
}
