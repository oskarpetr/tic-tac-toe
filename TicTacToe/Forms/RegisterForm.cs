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
    public partial class RegisterForm : Form {
        public RegisterForm() {
            InitializeComponent();
        }

        private void _buttonRegister_Click(object sender, EventArgs e) {
            var username = _inputName.Controls.Find("_input", true)[0].Text;
            var password = _inputPassword.Controls.Find("_input", true)[0].Text;

            new Account().SaveAccount(new Account() {
                Username = username,
                Password = password
            });

            // set login
            new Login().SetLogin(username);
            new Move().Screen(new HomeForm());
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e) {
            new Move().Screen(new HomeForm());
        }
    }
}
