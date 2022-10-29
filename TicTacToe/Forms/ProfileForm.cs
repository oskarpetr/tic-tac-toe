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
    public partial class ProfileForm : Form {
        public ProfileForm() {
            InitializeComponent();

            // set font
            new Window().SetFont((ControlCollection)this.Controls);

            // login states
            new Login().MenuState(_menu, this);
        }

        // menu actions
        private void _menuHome_Click(object sender, EventArgs e) {
            new Move().Screen(new HomeForm());
        }
    }
}
