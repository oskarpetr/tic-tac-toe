using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Utils;
using TicTacToe.User;

namespace TicTacToe.Forms {
    public partial class ShopForm : Form {
        public ShopForm() {
            InitializeComponent();

            // set font
            new Window().SetFont((ControlCollection)this.Controls);

            // login states
            new Login().MenuState(_menu, this);

            // bombs
            Account account = new Login().GetLogin();
            if (account != null) {
                _labelScore.Text = $"{account.Score} Score ({account.GetLevel()} Level)";
            }

            // set bombs
            _labelBombs.Text = $"{account.Bombs}x";
        }

        // menu actions
        private void _menuHome_Click(object sender, EventArgs e) {
            new Move().Screen(new HomeForm());
        }

        private void _buttonBomb_Click(object sender, EventArgs e) {
            Login login = new Login();
            Account account = login.GetLogin();

            // not enough
            if (account.Score < 100) {
                MessageBox.Show(
                    "You have not enough score in your account. Try winning some more games to earn some.",
                    "Not enough score",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            } else {
                new Account().UpdateAccount(account.Username, new Account() {
                    Username = account.Username,
                    Password = account.Password,
                    Bombs = account.Bombs + 1,
                    BombCounter = account.BombCounter,
                    Wins = account.Wins,
                    Score = account.Score - 100
                });
            }

            // bombs
            Account newAccount = new Login().GetLogin();
            if (newAccount != null) {
                _labelScore.Text = $"{newAccount.Score} Score ({newAccount.GetLevel()} Level)";
            }

            // set bombs
            _labelBombs.Text = $"{newAccount.Bombs}x";
        }
    }
}
