using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.utilities;

namespace TicTacToe.entity
{
    public static class Player
    {
        public static void turn(List<String> board)
        {

            int playerInput = InputUtil.inputInt("Player turn") - 1;
            if (board[playerInput] == "?")
            {
                board[playerInput] = "X";
            }
            else
            {
                Console.WriteLine("Try Again!");
                turn(board);
            }
        }
    }
}
