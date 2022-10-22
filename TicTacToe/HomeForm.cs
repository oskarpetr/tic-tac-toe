using TicTacToe.Utils;
using TicTacToe.User;

namespace TicTacToe {
    public partial class HomeForm : Form {
        public HomeForm() {
            InitializeComponent();

            // set font
            new Window().SetFont((ControlCollection)this.Controls);

            // initialize loginS
            Login login = new Login();
            login.CheckFirst();

            /*new Account().SaveAccount(new Account() {
                Username = "oskarpetr",
                Password = "123"
            });*/

            // login state handler
            //login.SetLogin("oskarpetr");
            LoginState(login.GetLogin());
        }

        // login states
        public void LoginState(Account account) {
            if (account == null) return;

            // menu state
            new Login().MenuState(_menu, this);

            // username
            _labelSubtitle.Text = $"Logged in as {account.Username}.";

            // statistics
            _panel.Controls.Remove(_labelNoStats);
                
            // wins label
            Label wins = new();
            wins.Text = $"Wins — {account.Wins}";
            wins.Dock = DockStyle.Top;
            wins.Font = new Font("SF Pro Rounded", 11);
            wins.ForeColor = Color.FromArgb(64, 64, 64);

            _panel.Controls.Add(wins);
        }

        private void _labelStats_Click(object sender, EventArgs e) {
            LoginState(new Login().GetLogin());
        }

        // menu actions
    }
}