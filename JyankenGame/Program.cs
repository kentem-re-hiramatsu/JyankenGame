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
                    Console.WriteLine(Constans.HANDSIGNAL_MESSAGE);
                    var inputJyankenType = int.Parse(Console.ReadLine()!);

                    manager.GetHandName(inputJyankenType);
                    manager.ShowWinLoseJuge();
                }
                else
                {
                    manager.ShowOverAllScores();
                }
            }
        }
    }
}
