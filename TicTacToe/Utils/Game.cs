using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TicTacToe.Utils {
    public class Game {
        public List<List<char?>> Board { get; set; } = new() {
            new() { null, null, null },
            new() { null, null, null },
            new() { null, null, null }
        };

        public enum Winner {
            X, O, Draw, NoWinner
        }

        public Winner CheckWinner(List<List<char?>> board) {
            int[,] combos = new int[,] {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },  // rows
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },  // columns
                { 0, 4, 8 }, { 2, 4, 6 }                // diagonals
            };

            // check for empty board
            bool empty = board.All(row => row.All(square => square == null));
            if (empty) return Winner.NoWinner;

            // check for winning combinations
            for (int i = 0; i < combos.GetLength(0); i++) {
                if (board[combos[i, 0] / 3][combos[i, 0] % 3] == 'x' &&
                    board[combos[i, 1] / 3][combos[i, 1] % 3] == 'x' &&
                    board[combos[i, 2] / 3][combos[i, 2] % 3] == 'x')
                    return Winner.X;

                else if (board[combos[i, 0] / 3][combos[i, 0] % 3] == 'o' &&
                    board[combos[i, 1] / 3][combos[i, 1] % 3] == 'o' &&
                    board[combos[i, 2] / 3][combos[i, 2] % 3] == 'o') {
                    return Winner.O;
                }
            }

            // check for draw
            bool draw = !board.Any(row => row.Any(square => square == null));
            if (draw) return Winner.Draw;

            // otherwise return no winner
            return Winner.NoWinner;
        }

        public int Minimax(List<List<char?>> board, int depth, bool ai) {
            int empty = 1;

            // empty squares
            for (int i = 0; i < board.Count; i++) {
                for (int j = 0; j < board[i].Count; j++) {
                    if (board[i][j] == null) empty++;
                }
            }

            /*if (CheckWinner(board) == Winner.O) return 1 * empty;
            else if (CheckWinner(board) == Winner.Draw) return 0;
            else if (CheckWinner(board) == Winner.X) return -1 * empty;*/

            return 99;
        }
    }
}
