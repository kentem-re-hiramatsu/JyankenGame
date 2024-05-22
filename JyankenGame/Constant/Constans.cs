using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JyankenGame.Constant
{
    static class Constans
    {
        public static readonly string SELECTION_MESSAGE = "じゃんけんをする：１　通算成績を見る：２　終了する：９";
        public static readonly string JYANKEN_MESSAGE = "じゃんけんの手札を入力してください(グー：０　チョキ：１　パー：２)";
        public static readonly string JYANKEN_ERROR_MESSAGE = "手の形が入力されていません";

        public static readonly string PLAYER_DEFAULT_MESSAGE = "あなた：{0}、BOT：{1} で{2}";
        public static readonly string PLAYER_WIN_MESSAGE = "あなたの勝ち！";
        public static readonly string PLAYER_LOSE_MESSAGE = "あなたの負け！";
        public static readonly string PLAYER_DRAW_MESSAGE = "あいこ！";
        public static readonly string PLAYER_OVER_ALL_SCORE_MESSAGE = "あなたの通算勝率は{0}％です。";
    }
}
