using TicTacToe.Utils;
using TicTacToe.User;
using TicTacToe.Forms;

namespace TicTacToe {
    public partial class HomeForm : Form {
        public HomeForm() {
            InitializeComponent();

            // set font
            new Window().SetFont((ControlCollection)this.Controls);

            // start position
            this.StartPosition = FormStartPosition.CenterScreen;

            // initialize login
            Login login = new Login();
            login.CheckFirst();

            /*new Account().SaveAccount(new Account() {
                Username = "oskarpetr",
                Password = "123"
            });*/

            // login state handler
            LoginState(login.GetLogin());

            // score
            Account account = login.GetLogin();
            _labelScore.Text = $"{account.Score} Score ({account.GetLevel()} Level)";
        }

        // login states
        public void LoginState(Account account) {
            if (account == null) return;

            // menu state
            new Login().MenuState(_menu, this);

            // username
            _labelSubtitle.Text = $"Logged in as {account.Username}.";

            // remove no stats
            _panel.Controls.Remove(_labelNoStats);

            // statistics labels
            int[] values = new int[] { account.Wins, account.Score, account.Bombs };
            string[] labels = new string[] { "Wins", "Score", "Bombs" };

            for (int i = 0; i < values.Length; i++) {
                Label wins = new();
                wins.Text = $"{labels[i]} - {values[i]}";
                wins.Font = new Font("SF Pro Rounded", 11);
                wins.ForeColor = Color.FromArgb(64, 64, 64);
                wins.Dock = DockStyle.Top;
                wins.Padding = new Padding(0, 5, 0, 0);

                _panelStats.Controls.Add(wins);
            }
        }

        // menu actions
        private void _menuLogin_Click(object sender, EventArgs e) {
            new Move().Screen(new LoginForm());      
        }
    }
}