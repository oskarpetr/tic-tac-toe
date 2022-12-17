using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using TicTacToe.Utils;
using TicTacToe.Forms;
using TicTacToe.User;

namespace TicTacToe.User {
    [Serializable]
    public class Login {
        // file storage
        private const string LOGIN = "login.data";

        public void SetLogin(string username) {
            using(var stream = File.Open(LOGIN, FileMode.OpenOrCreate)) {
                BinaryFormatter formatter = new();
                formatter.Serialize(stream, username);
            }
        }

        public Account GetLogin() {
            using (var stream = File.Open(LOGIN, FileMode.Open)) {
                BinaryFormatter formatter = new();
                string username = (string)formatter.Deserialize(stream);

                if(username != string.Empty) {
                    return new Account().GetAccount(username);
                } else {
                    return null;
                }
            }
        }

        public void CheckFirst() {
            if(!File.Exists(LOGIN))
                SetLogin(string.Empty);
        }

        public void MenuState(MenuStrip menu, Form form) {
            // cutting account
            ToolStripMenuItem account = (ToolStripMenuItem)menu.Items[1];
            menu.Items.RemoveAt(1);

            // add new items to menu strip
            string[] loggedItems = new string[] {
                "New Game",
                "Shop",
            };

            foreach (string item in loggedItems) {
                ToolStripItem tool = new ToolStripMenuItem(item);
                menu.Items.Add(tool);
                
                if (item == loggedItems[0] && form.GetType() != typeof(GameForm)) {
                    tool.Click += NewGame_Click;
                } else if(item == loggedItems[1] && form.GetType() != typeof(ShopForm)) {
                    tool.Click += Shop_Click;
                }
            }

            // adding account back
            menu.Items.Add(account);

            // add dropdown items to account
            account.DropDown.Items.Clear();
            string[] accountItems = new string[] {
                "Log Out"
            };

            foreach (string item in accountItems) {
                ToolStripItem tool = new ToolStripMenuItem(item);
                account.DropDownItems.Add(tool);

                if (item == accountItems[0]) {
                    tool.Click += LogOut_Click;
                }
            }
        }

        private void NewGame_Click(object? sender, EventArgs e) {
            new Move().Screen(new GameForm());
        }

        private void Shop_Click(object? sender, EventArgs e) {
            new Move().Screen(new ShopForm());
        }

        private void LogOut_Click(object? sender, EventArgs e) {
            new Login().SetLogin(string.Empty);
            new Move().Screen(new HomeForm());
        }
    }
}
