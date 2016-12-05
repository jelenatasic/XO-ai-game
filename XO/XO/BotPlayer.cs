using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class BotPlayer
    {
        Int16 bot_player_value; //0 -> racunar je O-igrac, 1 -> racunar je X-igrac
        List<Int16> move_list;
        

        public BotPlayer(Int16 value_x_o)
        {
            bot_player_value = value_x_o;
            move_list = new List<Int16>();
        }

        public Int16[] Play(GameState gs)
        {
            move_list.Clear();
            Int16 heuristic_value = -1;

            for(Int16 i = 0; i<3; i++)
                for (Int16 j = 0; j < 3; j++)
                {
                    if (gs.GetValueOnPosition(i, j) == -1)
                    {
                        Int16 value = gs.CalculateHeuristicValue(i, j, bot_player_value, true);
                        if (bot_player_value == 0)
                            value += gs.CalculateHeuristicValue(i, j, 1, false);
                        else
                            value += gs.CalculateHeuristicValue(i, j, 0, false);
                        if (value == heuristic_value)
                        {
                            move_list.Add(i);
                            move_list.Add(j);
                        }
                        if (value > heuristic_value)
                        {
                            move_list.Clear();
                            heuristic_value = value;
                            move_list.Add(i);
                            move_list.Add(j);
                        }
                    }
                }

            if (move_list.Count == 0)
                return new Int16[2] { -1, -1 }; //do ovoga ne bi trebalo da dodje 

            Random rnd = new Random();
            int rnd_number = rnd.Next();
            if (rnd_number % 2 == 1)
                rnd_number--;
            return new Int16[2] { move_list.ElementAt(rnd_number % move_list.Count), move_list.ElementAt((rnd_number % move_list.Count) +1) };
        }

        public Int16 GetBotValue()
        {
            return bot_player_value;
        }
    }
}
