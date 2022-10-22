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
    public partial class GameForm : Form {
        public GameForm() {
            InitializeComponent();

            // set font
            new Window().SetFont((ControlCollection)this.Controls);

            // initialze new board
            new Game().Initialize();

            // login state handler
            Login login = new Login();
            LoginState(login.GetLogin());
        }

        public void LoginState(Account account) {
            if (account != null) {
                // menu state
                new Login().MenuState(_menu, this);
            }
        }

        private void _menuHome_Click(object sender, EventArgs e) {
            new Move().Screen(new HomeForm());
        }
    }
}
