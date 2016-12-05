using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class GameState
    {
        private Int16[][] tabel;        //matrica 3x3, vrednost -1 oznacava nepopunjeno polje
                                            //0 -> O-igrac je popunio polje
                                            //1 -> X-igrac je popunio polje
        public GameState()
        {
            tabel = new Int16[3][];
            for( int i= 0; i <3; i++)
                tabel[i] = new Int16[3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tabel[i][j] = -1;
        }

        public void ChangeState(int pos_x, int pos_y, Int16 value)
        {
            if (value != 0 && value != 1)
                throw new Exception("Nevalidna vrednost stanja");

            tabel[pos_x][pos_y] = value;
        }

        public bool GameOver(Int16 player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabel[i][0] == tabel[i][1] && tabel[i][2] == player && tabel[i][0] == player)
                    return true; //pobeda po vretikali
                if (tabel[0][i] == tabel[1][i] && tabel[2][i] == player && tabel[0][i] == player)
                    return true; //pobeda po horizontali
            }

            if (tabel[0][0] == tabel[1][1] && tabel[2][2] == player && tabel[0][0] == player)
                return true; //pobeda po dijagonali1

            if (tabel[2][0] == tabel[1][1] && tabel[1][1] == tabel[0][2] && tabel[2][0] == player)
                return true; //pobeda po dijagonali2

            return false;
        }

        public bool Empty_Positions()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (tabel[i][j] == -1)
                        return true;
            return false;
        }

        public Int16 GetValueOnPosition(int pos_x, int pos_y)
        {
            return tabel[pos_x][pos_y];
        }

        public Int16 CalculateHeuristicValue(int pos_x, int pos_y, Int16 player, bool my_turn)
        {
            tabel[pos_x][pos_y] = player;
            Int16 heuristic_value = 0;

            if (GameOver(player))
                if (my_turn)
                    heuristic_value = 20;
                else
                    heuristic_value = 10;

            if (!my_turn)
            {
                tabel[pos_x][pos_y] = -1;
                return heuristic_value;
            }

            //mogucnost pobede u horizontali u kojoj je odigran potez?
            if ((tabel[0][pos_y] == -1 || tabel[0][pos_y] == player) &&
                (tabel[1][pos_y] == -1 || tabel[1][pos_y] == player) &&
                (tabel[2][pos_y] == -1 || tabel[2][pos_y] == player))
                heuristic_value++;

            //mogucnost pobede u vertikali u kojoj je odigran potez?
            if ((tabel[pos_x][0] == -1 || tabel[pos_x][0] == player) &&
                (tabel[pos_x][1] == -1 || tabel[pos_x][1] == player) &&
                (tabel[pos_x][2] == -1 || tabel[pos_x][2] == player))
                heuristic_value++;

            //ako se potez odnosi na dijagonalu, ispitati da li je pobeda na toj dijagonali moguca)
            if ((pos_x == 0 && pos_y == 0) || (pos_x == 1 && pos_y == 1) || (pos_x == 2 && pos_y == 2))
                if ((tabel[0][0] == -1 || tabel[0][0] == player) &&
                    (tabel[2][2] == -1 || tabel[2][2] == player) &&
                    (tabel[1][1] == -1 || tabel[1][1] == player))
                    heuristic_value++;
            if ((pos_x == 2 && pos_y == 0) || (pos_x == 1 && pos_y == 1) || (pos_x == 0 && pos_y == 2))
                if ((tabel[2][0] == -1 || tabel[2][0] == player) &&
                    (tabel[1][1] == -1 || tabel[1][1] == player) &&
                    (tabel[0][2] == -1 || tabel[0][2] == player))
                    heuristic_value++;

            tabel[pos_x][pos_y] = -1;
            return heuristic_value;
        }
    }
}