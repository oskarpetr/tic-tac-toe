using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace TicTacToe.User {
    [Serializable]
    public class Account {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Wins { get; set; } = 0;
        public int Score { get; set; } = 0;
        public int Bombs { get; set; } = 0;

        // file storage
        private const string ACCOUNTS = "accounts.data";

        public void SaveAccount(Account account) {
            using (var stream = File.Open(ACCOUNTS, FileMode.OpenOrCreate)) {
                BinaryFormatter formatter = new();

                List<Account> accounts = GetAccounts();
                accounts.Add(account);
                formatter.Serialize(stream, accounts);
            }
        }

        public Account UpdateAccount(string username) {
            Account account = GetAccount(username);
            return account;
        }

        public List<Account> GetAccounts() {
            using (var stream = File.Open(ACCOUNTS, FileMode.Open)) {
                BinaryFormatter formatter = new();
                return (List<Account>)formatter.Deserialize(stream);
            }
        }

        public Account GetAccount(string username) {
            List<Account> accounts = GetAccounts();
            Account account = accounts.FirstOrDefault(acc => acc.Username == username);
            return account;
        }

        public int GetLevel() {
            Login login = new Login();
            Account account = login.GetLogin();

            int level = 1;
            return level + account.Score / 50;
        }
    }
}
