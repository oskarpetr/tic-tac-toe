using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Utils {
    public class Game {
        private char[,] Board { get; set; } = new char[3, 3];

        public void Initialize() {
            for (int i = 0; i < Board.GetLength(0); i++) {
                for (int j = 0; j < Board.GetLength(1); j++) {
                    Board[i, j] = ' ';
                }
            }
        }

        public enum Winner {
            X, O, Draw, NoWinner
        }

        public Winner CheckWinner(char[,] board) {
            for (int i = 0; i < board.GetLength(0); i++) {
                // check rows
                if (board[i, 0] == 'x' && board[i, 1] == 'x' && board[i, 2] == 'x')
                    return Winner.X;
                if (board[i, 0] == 'o' && board[i, 1] == 'o' && board[i, 2] == 'o')
                    return Winner.O;

                // check columns
                if (board[0, i] == 'x' && board[1, i] == 'x' && board[2, i] == 'x')
                    return Winner.X;
                if (board[0, i] == 'o' && board[1, i] == 'o' && board[2, i] == 'o')
                    return Winner.O;
            }

            // check diagonals
            if (board[0, 0] == 'x' && board[1, 1] == 'x' && board[2, 2] == 'x')
                return Winner.X;
            if (board[0, 0] == 'o' && board[1, 1] == 'o' && board[2, 2] == 'o')
                return Winner.O;
            if (board[0, 2] == 'x' && board[1, 1] == 'x' && board[2, 0] == 'x')
                return Winner.X;
            if (board[0, 2] == 'o' && board[1, 1] == 'o' && board[2, 0] == 'o')
                return Winner.O;

            // check for full board
            bool draw = true;
            for (int i = 0; i < board.GetLength(0); i++) {
                for (int j = 0; j < board.GetLength(1); j++) {
                    if (board[i, j] == ' ') draw = false;
                }
            }

            // check draw
            if (draw)
                return Winner.Draw;

            // otherwise return no winner
            return Winner.NoWinner;
        }

        public void Minimax() { }
    }
}
