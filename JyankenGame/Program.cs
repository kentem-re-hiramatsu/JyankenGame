using JyankenGame.Constant;
using JyankenGame.Controller;

namespace JyankenGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JyankenManager manager = new JyankenManager();

            while (true)
            {
                Console.WriteLine(Constans.SELECTION_MESSAGE);

                var selectType = int.Parse(Console.ReadLine()!);

                if (selectType == 9)
                {
                    return;
                }

                if (selectType == 1)
                {
                    bool success = false;

                    while (!success)
                    {
                        try
                        {
                            success = true;

                            Console.WriteLine(Constans.JYANKEN_MESSAGE);
                            var inputJyankenType = int.Parse(Console.ReadLine()!);

                            manager.SetJyanken(inputJyankenType);
                        }
                        catch
                        {
                            success = false;
                            Console.WriteLine(Constans.JYANKEN_ERROR_MESSAGE);
                        }
                    }
                    Console.WriteLine(Constans.PLAYER_DEFAULT_MESSAGE,manager.GetHandName(manager.GetUserJyanken()),manager.GetHandName(manager.GetEnemyJyanken()), manager.WinLoseJuge());
                }
                else
                {
                    Console.WriteLine(Constans.PLAYER_OVER_ALL_SCORE_MESSAGE, manager.ShowOverAllScores());
                }
            }
        }
    }
}
