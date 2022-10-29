namespace TicTacToe.Forms {
    partial class GameForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this._menu = new System.Windows.Forms.MenuStrip();
            this._menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this._menuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this._menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this._menuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this._panel = new System.Windows.Forms.Panel();
            this._labelScore = new System.Windows.Forms.Label();
            this._square2 = new System.Windows.Forms.PictureBox();
            this._square5 = new System.Windows.Forms.PictureBox();
            this._square7 = new System.Windows.Forms.PictureBox();
            this._square4 = new System.Windows.Forms.PictureBox();
            this._square6 = new System.Windows.Forms.PictureBox();
            this._square3 = new System.Windows.Forms.PictureBox();
            this._square1 = new System.Windows.Forms.PictureBox();
            this._square8 = new System.Windows.Forms.PictureBox();
            this._square0 = new System.Windows.Forms.PictureBox();
            this._imageBoard = new System.Windows.Forms.PictureBox();
            this._labelSubtitle = new System.Windows.Forms.Label();
            this._labelTitle = new System.Windows.Forms.Label();
            this._menu.SuspendLayout();
            this._panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._square2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._square5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._square7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._square4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._square6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._square3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._square1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._square8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._square0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._imageBoard)).BeginInit();
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
            this._menu.TabIndex = 3;
            // 
            // _menuHome
            // 
            this._menuHome.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._menuHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this._menuHome.Name = "_menuHome";
            this._menuHome.Size = new System.Drawing.Size(60, 22);
            this._menuHome.Text = "Home";
            this._menuHome.Click += new System.EventHandler(this._menuHome_Click);
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
            // 
            // _menuRegister
            // 
            this._menuRegister.Name = "_menuRegister";
            this._menuRegister.Size = new System.Drawing.Size(143, 26);
            this._menuRegister.Text = "Register";
            // 
            // _panel
            // 
            this._panel.AutoSize = true;
            this._panel.BackColor = System.Drawing.Color.Transparent;
            this._panel.Controls.Add(this._labelScore);
            this._panel.Controls.Add(this._square2);
            this._panel.Controls.Add(this._square5);
            this._panel.Controls.Add(this._square7);
            this._panel.Controls.Add(this._square4);
            this._panel.Controls.Add(this._square6);
            this._panel.Controls.Add(this._square3);
            this._panel.Controls.Add(this._square1);
            this._panel.Controls.Add(this._square8);
            this._panel.Controls.Add(this._square0);
            this._panel.Controls.Add(this._imageBoard);
            this._panel.Controls.Add(this._labelSubtitle);
            this._panel.Controls.Add(this._labelTitle);
            this._panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel.Location = new System.Drawing.Point(0, 26);
            this._panel.Name = "_panel";
            this._panel.Padding = new System.Windows.Forms.Padding(50, 30, 50, 30);
            this._panel.Size = new System.Drawing.Size(1262, 647);
            this._panel.TabIndex = 6;
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
            this._labelScore.TabIndex = 17;
            this._labelScore.Text = "Score";
            this._labelScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _square2
            // 
            this._square2.Location = new System.Drawing.Point(730, 82);
            this._square2.Name = "_square2";
            this._square2.Size = new System.Drawing.Size(160, 160);
            this._square2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._square2.TabIndex = 16;
            this._square2.TabStop = false;
            this._square2.Click += new System.EventHandler(this._square_Click);
            // 
            // _square5
            // 
            this._square5.Location = new System.Drawing.Point(730, 252);
            this._square5.Name = "_square5";
            this._square5.Size = new System.Drawing.Size(160, 160);
            this._square5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._square5.TabIndex = 15;
            this._square5.TabStop = false;
            this._square5.Click += new System.EventHandler(this._square_Click);
            // 
            // _square7
            // 
            this._square7.Location = new System.Drawing.Point(560, 422);
            this._square7.Name = "_square7";
            this._square7.Size = new System.Drawing.Size(160, 160);
            this._square7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._square7.TabIndex = 14;
            this._square7.TabStop = false;
            this._square7.Click += new System.EventHandler(this._square_Click);
            // 
            // _square4
            // 
            this._square4.Location = new System.Drawing.Point(560, 252);
            this._square4.Name = "_square4";
            this._square4.Size = new System.Drawing.Size(160, 160);
            this._square4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._square4.TabIndex = 13;
            this._square4.TabStop = false;
            this._square4.Click += new System.EventHandler(this._square_Click);
            // 
            // _square6
            // 
            this._square6.Location = new System.Drawing.Point(390, 422);
            this._square6.Name = "_square6";
            this._square6.Size = new System.Drawing.Size(160, 160);
            this._square6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._square6.TabIndex = 12;
            this._square6.TabStop = false;
            this._square6.Click += new System.EventHandler(this._square_Click);
            // 
            // _square3
            // 
            this._square3.Location = new System.Drawing.Point(390, 252);
            this._square3.Name = "_square3";
            this._square3.Size = new System.Drawing.Size(160, 160);
            this._square3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._square3.TabIndex = 11;
            this._square3.TabStop = false;
            this._square3.Click += new System.EventHandler(this._square_Click);
            // 
            // _square1
            // 
            this._square1.Location = new System.Drawing.Point(560, 82);
            this._square1.Name = "_square1";
            this._square1.Size = new System.Drawing.Size(160, 160);
            this._square1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._square1.TabIndex = 10;
            this._square1.TabStop = false;
            this._square1.Click += new System.EventHandler(this._square_Click);
            // 
            // _square8
            // 
            this._square8.Location = new System.Drawing.Point(730, 422);
            this._square8.Name = "_square8";
            this._square8.Size = new System.Drawing.Size(160, 160);
            this._square8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._square8.TabIndex = 9;
            this._square8.TabStop = false;
            this._square8.Click += new System.EventHandler(this._square_Click);
            // 
            // _square0
            // 
            this._square0.Location = new System.Drawing.Point(390, 82);
            this._square0.Name = "_square0";
            this._square0.Size = new System.Drawing.Size(160, 160);
            this._square0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._square0.TabIndex = 8;
            this._square0.TabStop = false;
            this._square0.Click += new System.EventHandler(this._square_Click);
            // 
            // _imageBoard
            // 
            this._imageBoard.Image = global::TicTacToe.Properties.Resources.Board;
            this._imageBoard.Location = new System.Drawing.Point(390, 82);
            this._imageBoard.Name = "_imageBoard";
            this._imageBoard.Size = new System.Drawing.Size(500, 500);
            this._imageBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._imageBoard.TabIndex = 7;
            this._imageBoard.TabStop = false;
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
            this._labelSubtitle.Size = new System.Drawing.Size(163, 26);
            this._labelSubtitle.TabIndex = 5;
            this._labelSubtitle.Text = "Make the first move.";
            // 
            // _labelTitle
            // 
            this._labelTitle.AutoSize = true;
            this._labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelTitle.Font = new System.Drawing.Font("SF Pro Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelTitle.Location = new System.Drawing.Point(50, 30);
            this._labelTitle.Name = "_labelTitle";
            this._labelTitle.Size = new System.Drawing.Size(218, 48);
            this._labelTitle.TabIndex = 4;
            this._labelTitle.Text = "Tic Tac Toe";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this._panel);
            this.Controls.Add(this._menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "Tic Tac Toe";
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this._panel.ResumeLayout(false);
            this._panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._square2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._square5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._square7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._square4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._square6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._square3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._square1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._square8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._square0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._imageBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip _menu;
        private ToolStripMenuItem _menuHome;
        private ToolStripMenuItem _menuAccount;
        private ToolStripMenuItem _menuLogin;
        private ToolStripMenuItem _menuRegister;
        private Panel _panel;
        private Label _labelSubtitle;
        private Label _labelTitle;
        private PictureBox _square2;
        private PictureBox _square5;
        private PictureBox _square7;
        private PictureBox _square4;
        private PictureBox _square6;
        private PictureBox _square3;
        private PictureBox _square1;
        private PictureBox _square8;
        private PictureBox _square0;
        private Label _labelScore;
        private PictureBox _imageBoard;
    }
}