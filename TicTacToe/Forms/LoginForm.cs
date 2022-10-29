using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.User;
using TicTacToe.Utils;

namespace TicTacToe.Forms {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void _buttonLogin_Click(object sender, EventArgs e) {
            var username = _inputName.Controls.Find("_input", true)[0].Text;
            var password = _inputPassword.Controls.Find("_input", true)[0].Text;

            Account account = new Account().GetAccount(username);

            // username is not found
            if (account == null) {
                MessageBox.Show(
                    "No account was found associated with this username. You can try again with a different one.",
                    "Invalid username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // invalid password
            if(password != account.Password) {
                MessageBox.Show(
                    "Password was entered incorrectly for this account. You can try again with a different one.",
                    "Invalid password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // set login
            new Login().SetLogin(username);
            new Move().Screen(new HomeForm());
        }
    }
}
