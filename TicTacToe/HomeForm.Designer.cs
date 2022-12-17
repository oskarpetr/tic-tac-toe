namespace TicTacToe {
    partial class HomeForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this._menu = new System.Windows.Forms.MenuStrip();
            this._menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this._menuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this._menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this._menuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this._panel = new System.Windows.Forms.Panel();
            this._labelScore = new System.Windows.Forms.Label();
            this._labelNoStats = new System.Windows.Forms.Label();
            this._labelStats = new System.Windows.Forms.Label();
            this._labelSubtitle = new System.Windows.Forms.Label();
            this._labelTitle = new System.Windows.Forms.Label();
            this._panelStats = new System.Windows.Forms.Panel();
            this._menu.SuspendLayout();
            this._panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menu
            // 
            this._menu.BackColor = System.Drawing.Color.White;
            this._menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuHome,
            this._menuAccount});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(1262, 26);
            this._menu.TabIndex = 2;
            // 
            // _menuHome
            // 
            this._menuHome.BackColor = System.Drawing.Color.White;
            this._menuHome.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._menuHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this._menuHome.Name = "_menuHome";
            this._menuHome.Size = new System.Drawing.Size(60, 22);
            this._menuHome.Text = "Home";
            // 
            // _menuAccount
            // 
            this._menuAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuLogin,
            this._menuRegister});
            this._menuAccount.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._menuAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this._menuAccount.Name = "_menuAccount";
            this._menuAccount.Size = new System.Drawing.Size(76, 22);
            this._menuAccount.Text = "Account";
            // 
            // _menuLogin
            // 
            this._menuLogin.Name = "_menuLogin";
            this._menuLogin.Size = new System.Drawing.Size(143, 26);
            this._menuLogin.Text = "Login";
            this._menuLogin.Click += new System.EventHandler(this._menuLogin_Click);
            // 
            // _menuRegister
            // 
            this._menuRegister.Name = "_menuRegister";
            this._menuRegister.Size = new System.Drawing.Size(143, 26);
            this._menuRegister.Text = "Register";
            this._menuRegister.Click += new System.EventHandler(this._menuRegister_Click);
            // 
            // _panel
            // 
            this._panel.AutoSize = true;
            this._panel.BackColor = System.Drawing.Color.Transparent;
            this._panel.Controls.Add(this._labelScore);
            this._panel.Controls.Add(this._labelNoStats);
            this._panel.Controls.Add(this._labelStats);
            this._panel.Controls.Add(this._labelSubtitle);
            this._panel.Controls.Add(this._labelTitle);
            this._panel.Dock = System.Windows.Forms.DockStyle.Top;
            this._panel.Location = new System.Drawing.Point(0, 26);
            this._panel.Name = "_panel";
            this._panel.Padding = new System.Windows.Forms.Padding(50, 30, 50, 0);
            this._panel.Size = new System.Drawing.Size(1262, 208);
            this._panel.TabIndex = 8;
            // 
            // _labelScore
            // 
            this._labelScore.BackColor = System.Drawing.Color.Transparent;
            this._labelScore.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._labelScore.Location = new System.Drawing.Point(995, 30);
            this._labelScore.Name = "_labelScore";
            this._labelScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._labelScore.Size = new System.Drawing.Size(217, 21);
            this._labelScore.TabIndex = 18;
            this._labelScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelNoStats
            // 
            this._labelNoStats.AutoSize = true;
            this._labelNoStats.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelNoStats.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelNoStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._labelNoStats.Location = new System.Drawing.Point(50, 182);
            this._labelNoStats.Name = "_labelNoStats";
            this._labelNoStats.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this._labelNoStats.Size = new System.Drawing.Size(114, 26);
            this._labelNoStats.TabIndex = 7;
            this._labelNoStats.Text = "Not available.";
            // 
            // _labelStats
            // 
            this._labelStats.AutoSize = true;
            this._labelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelStats.Font = new System.Drawing.Font("SF Pro Rounded", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelStats.ForeColor = System.Drawing.Color.Black;
            this._labelStats.Location = new System.Drawing.Point(50, 104);
            this._labelStats.Name = "_labelStats";
            this._labelStats.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this._labelStats.Size = new System.Drawing.Size(113, 78);
            this._labelStats.TabIndex = 6;
            this._labelStats.Text = "Statistics";
            // 
            // _labelSubtitle
            // 
            this._labelSubtitle.AutoSize = true;
            this._labelSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelSubtitle.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._labelSubtitle.Location = new System.Drawing.Point(50, 78);
            this._labelSubtitle.Name = "_labelSubtitle";
            this._labelSubtitle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this._labelSubtitle.Size = new System.Drawing.Size(192, 26);
            this._labelSubtitle.TabIndex = 5;
            this._labelSubtitle.Text = "No account is logged in.";
            // 
            // _labelTitle
            // 
            this._labelTitle.AutoSize = true;
            this._labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelTitle.Font = new System.Drawing.Font("SF Pro Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelTitle.Location = new System.Drawing.Point(50, 30);
            this._labelTitle.Name = "_labelTitle";
            this._labelTitle.Size = new System.Drawing.Size(455, 48);
            this._labelTitle.TabIndex = 4;
            this._labelTitle.Text = "Welcome to Tic Tac Toe!";
            // 
            // _panelStats
            // 
            this._panelStats.AutoSize = true;
            this._panelStats.BackColor = System.Drawing.Color.Transparent;
            this._panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelStats.Location = new System.Drawing.Point(0, 234);
            this._panelStats.Name = "_panelStats";
            this._panelStats.Padding = new System.Windows.Forms.Padding(50, 0, 50, 30);
            this._panelStats.Size = new System.Drawing.Size(1262, 30);
            this._panelStats.TabIndex = 9;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this._panelStats);
            this.Controls.Add(this._panel);
            this.Controls.Add(this._menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menu;
            this.Name = "HomeForm";
            this.Text = "Tic tac toe";
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this._panel.ResumeLayout(false);
            this._panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip _menu;
        private ToolStripMenuItem _menuAccount;
        private ToolStripMenuItem _menuHome;
        private ToolStripMenuItem _menuLogin;
        private ToolStripMenuItem _menuRegister;
        private Panel _panel;
        private Label _labelNoStats;
        private Label _labelStats;
        private Label _labelSubtitle;
        private Label _labelTitle;
        private Panel _panelStats;
        private Label _labelScore;
    }
}