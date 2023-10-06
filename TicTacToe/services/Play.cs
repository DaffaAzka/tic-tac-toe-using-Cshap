using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.entity;
using TicTacToe.utilities;

namespace TicTacToe.services
{
    public class Play
    {
        List<String> boardData = new List<string> {"?", "?", "?", "?", "?", "?", "?", "?", "?" };

        public void board()
        {
            Console.WriteLine("___________________");
            Console.WriteLine("|   TIC TAC TOE   |");
            Console.WriteLine("-------------------");

            Console.WriteLine(" ");

            Console.WriteLine("===================");
            Console.WriteLine("=  " + boardData[0] + "  =  " + boardData[1] + "  =  " + boardData[2] + " =");
            Console.WriteLine("===================");
            Console.WriteLine("=  " + boardData[3] + "  =  " + boardData[4] + "  =  " + boardData[5] + " =");
            Console.WriteLine("===================");
            Console.WriteLine("=  " + boardData[6] + "  =  " + boardData[7] + "  =  " + boardData[8] + " =");
            Console.WriteLine("===================");

        }

        public void start()
        {
            for (int i = 0; i < 5; i++)
            {
                if (winAndLoseCondition())
                {
                    List<String> boardData = new List<string> { "?", "?", "?", "?", "?", "?", "?", "?", "?" };
                    break;
                }

                if (i == 4)
                {
                    if (winAndLoseCondition())
                    {
                        break;
                    }
                    else
                    {
                        board();
                        Console.WriteLine("Tie!");
                    }
                }
                else
                {
                    board();
                    Player.turn(boardData);
                    Bot.turn(boardData);
                    Console.Clear();
                }

                
            }

            Console.WriteLine("Create by: Daffa Azka");

            Console.WriteLine(" ");

            while (true)
            {
                String s = InputUtil.inputStr("Try Again? (y/n)");

                if (s == "y")
                {
                    boardData = new List<string> { "?", "?", "?", "?", "?", "?", "?", "?", "?" };
                    Console.Clear();
                    start();
                }
                else
                {
                    break;
                }
            }
        }



        public bool winAndLoseCondition()
        {
            if(boardData[0] == "X" && boardData[1] == "X" && boardData[2] == "X") {
                board();
                Console.WriteLine("Player Win!");
                return true;
            } else if (boardData[0] == "O" && boardData[1] == "O" && boardData[2] == "O")
            {
                board();
                Console.WriteLine("Bot Win!");
                return true;
            }
            else if (boardData[3] == "X" && boardData[4] == "X" && boardData[5] == "X")
            {
                board();
                Console.WriteLine("Player Win!");
                return true;
            }
            else if (boardData[3] == "O" && boardData[4] == "O" && boardData[5] == "O")
            {
                board();
                Console.WriteLine("Bot Win!");
                return true;
            }
            else if (boardData[6] == "X" && boardData[7] == "X" && boardData[8] == "X")
            {
                board();
                Console.WriteLine("Player Win!");
                return true;
            }
            else if (boardData[6] == "O" && boardData[7] == "O" && boardData[8] == "O")
            {
                board();
                Console.WriteLine("Bot Win!");
                return true;
            }
            else if (boardData[0] == "X" && boardData[3] == "X" && boardData[6] == "X")
            {
                board();
                Console.WriteLine("Player Win!");
                return true;
            }
            else if (boardData[0] == "O" && boardData[3] == "O" && boardData[6] == "O")
            {
                board();
                Console.WriteLine("Bot Win!");
                return true;
            }
            else if (boardData[1] == "X" && boardData[4] == "X" && boardData[7] == "X")
            {
                board();
                Console.WriteLine("Player Win!");
                return true;
            }
            else if (boardData[1] == "O" && boardData[4] == "O" && boardData[7] == "O")
            {
                board();
                Console.WriteLine("Bot Win!");
                return true;
            }
            else if (boardData[2] == "X" && boardData[5] == "X" && boardData[8] == "X")
            {
                board();
                Console.WriteLine("Player Win!");
                return true;
            }
            else if (boardData[2] == "O" && boardData[5] == "O" && boardData[8] == "O")
            {
                board();
                Console.WriteLine("Bot Win!");
                return true;
            }
            else if (boardData[0] == "X" && boardData[4] == "X" && boardData[8] == "X")
            {
                board();
                Console.WriteLine("Player Win!");
                return true;
            }
            else if (boardData[0] == "O" && boardData[4] == "O" && boardData[8] == "O")
            {
                board();
                Console.WriteLine("Bot Win!");
                return true;
            }
            else if (boardData[2] == "X" && boardData[4] == "X" && boardData[6] == "X")
            {
                board();
                Console.WriteLine("Player Win!");
                return true;
            }
            else if (boardData[2] == "O" && boardData[4] == "O" && boardData[6] == "O")
            {
                board();
                Console.WriteLine("Bot Win!");
                return true;
            }
            return false;
        }
    }
}
