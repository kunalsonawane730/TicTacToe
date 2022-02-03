using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTacToe
{
    public class TicTacToeGame
    {
        public int player = 1;
        public int choice;
        public int flag = 0;
        public void board()
        {
            char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Console.WriteLine("Player1:X and Player2:O");
            Console.WriteLine("\n");
            if (player % 2 == 0)//checking the chance of the player
            {
                Console.WriteLine("Player 2 Chance");
            }
            else
            {
                Console.WriteLine("Player 1 Chance");
            }
            Console.WriteLine("\n");
             choice = int.Parse(Console.ReadLine());

            if (board[choice] != 'X' && board[choice] != 'O')
            {
                if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                {
                    board[choice] = 'O';
                    player++;
                }
                else
                {
                    board[choice] = 'X';
                    player++;

                }
            }
        }
    }
}
