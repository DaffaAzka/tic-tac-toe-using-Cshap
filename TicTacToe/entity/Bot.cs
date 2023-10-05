using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.entity
{
    public static class Bot
    {
        public static void turn(List<String> board) 
        {
            System.Random random = new System.Random();
            int r = random.Next(board.Count);

            if (board[r] == "?")
            {
                board[r] = "o";
            } else
            {
                turn(board);
            }
        }
    }
}
