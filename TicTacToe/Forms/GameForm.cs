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
using System.Media;

namespace TicTacToe.Forms {
    public partial class GameForm : Form {
        // new game
        private Game game = new Game();
        private Game.Winner _winner = Game.Winner.NoWinner;

        public GameForm() {
            InitializeComponent();

            // set font
            new Window().SetFont((ControlCollection)this.Controls);

            // login states
            Login login = new Login();
            login.MenuState(_menu, this);

            // score
            Account account = login.GetLogin();
            if (account != null) {
                _labelScore.Text = $"{account.Score} Score ({account.GetLevel()} Level)";
            }

            // bombs
            _labelBombs.Text = $"{account.Bombs} bombs";
        }

        // game
        int rounds = 0;
        private void _square_Click(object sender, EventArgs e) {
            PictureBox square = (PictureBox)sender;

            // get square position
            int position = int.Parse(square.Name[square.Name.Length - 1].ToString());

            if(bombMode) {
                square.Image = Properties.Resources.Bomb;
                Sleep(1000);

                using (var soundPlayer = new SoundPlayer("explosion.wav")) {
                    soundPlayer.Play();
                }

                Sleep(2000);
                square.Image = null;

                bombMode = false;
            } else { 
                // if player wants interact after game
                if (game.CheckWinner(game.Board) != Game.Winner.NoWinner) {
                    return;
                }

                // update board and UI
                if (game.Board[position / 3][position % 3] != 'o') { 
                    game.Board[position / 3][position % 3] = 'x';
                    square.Image = Properties.Resources.X;
                } else {
                    return;
                }

                // if player won
                if (game.CheckWinner(game.Board) != Game.Winner.NoWinner) {
                    WinForm win = new WinForm(game.CheckWinner(game.Board));
                    _winner = game.CheckWinner(game.Board);

                    win.Show();

                    int centerX = this.Left + (this.Width / 2) - (win.Width / 2);
                    int centerY = this.Top + (this.Height / 2) - (win.Height / 2);
                    win.DesktopLocation = new Point(centerX, centerY);

                    win.OnHomeClicked += Win_OnHomeClicked;
                    win.OnNextClicked += Win_OnNextClicked;

                    return;
                }
            }

            // ai makes move
            MakeAIMove();


            // if player won
            if (game.CheckWinner(game.Board) != Game.Winner.NoWinner) {
                WinForm win = new WinForm(game.CheckWinner(game.Board));
                _winner = game.CheckWinner(game.Board);

                win.Show();

                int centerX = this.Left + (this.Width / 2) - (win.Width / 2);
                int centerY = this.Top + (this.Height / 2) - (win.Height / 2);
                win.DesktopLocation = new Point(centerX, centerY);

                return;
            }

            rounds++;
        }

        private void Sleep(int time) {
            Thread thread = new Thread(delegate() {
                System.Threading.Thread.Sleep(time);
            });

            thread.Start();
            while (thread.IsAlive) Application.DoEvents();
        }

        private void Win_OnNextClicked() {
            AddScore();
            new Move().Screen(new GameForm());
        }
        
        private void Win_OnHomeClicked() {
            AddScore();
            new Move().Screen(new HomeForm());
        }

        public void MakeAIMove() {
            int empty = 0;
            List<int> available = new List<int>();

            // empty squares
            for (int i = 0; i < game.Board.Count; i++) {
                for (int j = 0; j < game.Board[i].Count; j++) {
                    if (game.Board[i][j] == null) {
                        empty++;
                        available.Add(i * 3 + j);
                    }
                }
            }

            int move = -1;

            if(empty == 8) {
                int random = new Random().Next(0, available.Count);
                move = available[random];
            } else {
                move = game.Minimax(game.Board, 8, true);
            }

            PictureBox square = (PictureBox)_panel.Controls.Find($"_square{move}", true)[0];

            // make move
            game.Board[move / 3][move % 3] = 'o';
            square.Image = Properties.Resources.O;
        }

        private void AddScore() {
            int score = 0;

            if (_winner == Game.Winner.X) { score = 25; }
            else if (_winner == Game.Winner.Draw) { score = 10; }

            // add score
            if (_winner == Game.Winner.X || _winner == Game.Winner.Draw) {
                Login login = new Login();
                Account account = login.GetLogin();

                new Account().UpdateAccount(account.Username, new Account() {
                    Username = account.Username,
                    Password = account.Password,
                    Bombs = account.Bombs + (account.BombCounter == 3 ? 1 : 0),
                    BombCounter = (account.BombCounter == 4 ? 1 : account.BombCounter + 1),
                    Wins = account.Wins + (_winner == Game.Winner.X ? 1 : 0),
                    Score = account.Score + score
                });
            }

            // hide current screen
            Form form = Application.OpenForms.Cast<Form>().Last();
            form.Close();
        }

        // menu actions
        private void _menuHome_Click(object sender, EventArgs e) {
            new Move().Screen(new HomeForm());
        }

        private void _menuRegister_Click(object sender, EventArgs e) {
            new Move().Screen(new RegisterForm());
        }

        private bool bombMode = false;
        private void _buttonBomb_Click(object sender, EventArgs e) {
            Login login = new Login();
            Account account = login.GetLogin();

            // not enough
            if (account.Bombs < 1) {
                MessageBox.Show(
                    "You have not enough bombs in your account. Try winning some more games to earn some.",
                    "Not enough bombs",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            } else {
                bombMode = true;

                new Account().UpdateAccount(account.Username, new Account() {
                    Username = account.Username,
                    Password = account.Password,
                    Bombs = account.Bombs - 1,
                    BombCounter = account.BombCounter,
                    Wins = account.Wins,
                    Score = account.Score
                });
            }
        }
    }
}
