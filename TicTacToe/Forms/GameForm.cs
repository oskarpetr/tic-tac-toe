using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using TicTacToe.Utils;
using TicTacToe.User;

namespace TicTacToe.Forms {
    public partial class GameForm : Form {
        // new game
        private Game game = new Game();

        public GameForm() {
            InitializeComponent();

            // set font
            new Window().SetFont((ControlCollection)this.Controls);

            // login states
            Login login = new Login();
            login.MenuState(_menu, this);

            // score
            Account account = login.GetLogin();
            _labelScore.Text = $"{account.Score} Score ({account.GetLevel()} Level)";
        }

        // game
        int rounds = 0;
        private void _square_Click(object sender, EventArgs e) {
            PictureBox square = (PictureBox)sender;

            // if player wants interact after game
            if (game.CheckWinner(game.Board) != Game.Winner.NoWinner) {
                return;
            }

            // get square position
            int position = int.Parse(square.Name[square.Name.Length - 1].ToString());
            bool player = rounds % 2 == 0;

            // update board and UI
            game.Board[position / 3][position % 3] = player ? 'x' : 'o';
            square.Image = player ? Properties.Resources.X : Properties.Resources.O;

            int move = game.Minimax(new List<List<char?>>() {
                new() { 'x', null, 'o' },
                new() { 'o', 'o', 'x' },
                new() { 'o', null, 'x' },
            }, 3, true);

            // if player won
            if (game.CheckWinner(game.Board) != Game.Winner.NoWinner) {
                return;
            }

            rounds++;
        }

        // menu actions
        private void _menuHome_Click(object sender, EventArgs e) {
            new Move().Screen(new HomeForm());
        }
    }
}
