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
        public static readonly string HANDSIGNAL_MESSAGE = "じゃんけんの手札を入力してください(グー：0　パー：1　チョキ：2)";
        public static readonly string HANDSIGNAL_ERROR_MESSAGE = "手の形が入力されていません";
        public static readonly string PLAYER_WIN_MESSAGE = "あなた：{0}、BOT：{1} であなたの勝ち！";
        public static readonly string PLAYER_LOSE_MESSAGE = "あなた：{0}、BOT：{1} であなたの負け！";
        public static readonly string PLAYER_DRAW_MESSAGE = "あなた：{0}、BOT：{1} であいこ！";
        public static readonly string PLAYER_OVER_ALL_SCORE_MESSAGE = "あなたの通算勝率は{0}％です。";
    }
}
