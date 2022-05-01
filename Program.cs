using System;
using System.Collections.Generic;

namespace CSE210_01
{
    class Program
    {
        static void Main(string[] args)
        {  
             List<int> board = CreateBoard();
             DisplayBoard(board);
        }
        
        static List<int> CreateBoard()
        {
            List<int> board = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                board.Add(i + 1);
            }
            return board;
        }

         static void DisplayBoard(List<int> board)
        {
            Console.WriteLine();
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            Console.WriteLine();  
        }

        
        

    }
}
