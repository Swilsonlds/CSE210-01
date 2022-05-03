/*Spencer Wilson CSE210 Tic-Tac-Toe*/

using System;
using System.Collections.Generic;

namespace CSE210_01
{
    class Program
    {
        static void Main(string[] args)
        {  
            string player = "o";
             List<string> board = new List<string>();
             board.Add("1");
             board.Add("2");
             board.Add("3");
             board.Add("4");
             board.Add("5");
             board.Add("6");
             board.Add("7");
             board.Add("8");
             board.Add("9");
             int winner = HasWinner(board);
             DisplayBoard(board);

             while (winner != 1) 
             {
                 MakeMove(player, board);
                 winner = HasWinner(board);
                 player = NextPlayer(player);
                 DisplayBoard(board);
             }

             Console.WriteLine($"Game Over, {NextPlayer(player)}'s win!");
             
        }

         static void DisplayBoard(List<string> board)
        {
            Console.WriteLine();
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            Console.WriteLine();  
        }

        static int HasWinner(List<string> board)
        {
            if (board[0] == board[1] && board[1] == board[2])
            {
                return 1;
            }

            else if (board[3] == board[4] && board[4] == board[5])
            {
                return 1;
            }

            else if (board[6] == board[7] && board[7] == board[8])
            {
                return 1;
            }

            else if (board[0] == board[3] && board[3] == board[6])
            {
                return 1;
            }

            else if (board[1] == board[4] && board[4] == board[7])
            {
                return 1;
            }

            else if (board[2] == board[5] && board[5] == board[8])
            {
                return 1;
            }

            else if (board[0] == board[4] && board[4] == board[8])
            {
                return 1;
            }

            else if (board[2] == board[4] && board[4] == board[6])
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }

       /* static bool IsADraw(List<string>board)
        {
            for (int i = 0; i < 10; i++)
                if (board[i] != "x" & board[i] != "o")
                {
                    return false;
                }
                else 
                {return true;} 
        } */

        static void MakeMove(string player, List<string> board)  
        {
            Console.Write($"{player}'s turn to choose a square (1-9): ");
            string squareString = Console.ReadLine();
            int squareInt = int.Parse(squareString);
            board[squareInt - 1] = player;
        }

        static string NextPlayer(string current)
        {
            if (current == "")
            {
                return "x";
            }

            else if (current == "o")
            {
                return "x";
            }

            else
            {
                return "o";
            }
        }

    }
}
