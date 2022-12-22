namespace TicTacToe.Forms {
    partial class ShopForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this._menu = new System.Windows.Forms.MenuStrip();
            this._menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this._menuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this._menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this._menuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this._panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this._buttonBomb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._labelScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._labelBombs = new System.Windows.Forms.Label();
            this._labelSubtitle = new System.Windows.Forms.Label();
            this._labelTitle = new System.Windows.Forms.Label();
            this._menu.SuspendLayout();
            this._panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this._menuHome.BackColor = System.Drawing.Color.White;
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
            this._panel.Controls.Add(this.pictureBox2);
            this._panel.Controls.Add(this._buttonBomb);
            this._panel.Controls.Add(this.label1);
            this._panel.Controls.Add(this._labelScore);
            this._panel.Controls.Add(this.pictureBox1);
            this._panel.Controls.Add(this._labelBombs);
            this._panel.Controls.Add(this._labelSubtitle);
            this._panel.Controls.Add(this._labelTitle);
            this._panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel.Location = new System.Drawing.Point(0, 26);
            this._panel.Name = "_panel";
            this._panel.Padding = new System.Windows.Forms.Padding(50, 30, 50, 30);
            this._panel.Size = new System.Drawing.Size(1262, 647);
            this._panel.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TicTacToe.Properties.Resources.Bomb;
            this.pictureBox2.Location = new System.Drawing.Point(50, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // _buttonBomb
            // 
            this._buttonBomb.Location = new System.Drawing.Point(50, 176);
            this._buttonBomb.Name = "_buttonBomb";
            this._buttonBomb.Size = new System.Drawing.Size(128, 29);
            this._buttonBomb.TabIndex = 24;
            this._buttonBomb.Text = "Buy a bomb";
            this._buttonBomb.UseVisualStyleBackColor = true;
            this._buttonBomb.Click += new System.EventHandler(this._buttonBomb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "100 score";
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
            this._labelScore.TabIndex = 22;
            this._labelScore.Text = "Score";
            this._labelScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicTacToe.Properties.Resources.Bomb;
            this.pictureBox1.Location = new System.Drawing.Point(1179, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // _labelBombs
            // 
            this._labelBombs.BackColor = System.Drawing.Color.Transparent;
            this._labelBombs.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelBombs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._labelBombs.Location = new System.Drawing.Point(992, 58);
            this._labelBombs.Name = "_labelBombs";
            this._labelBombs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._labelBombs.Size = new System.Drawing.Size(188, 21);
            this._labelBombs.TabIndex = 19;
            this._labelBombs.Text = "0x";
            this._labelBombs.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this._labelSubtitle.Size = new System.Drawing.Size(158, 26);
            this._labelSubtitle.TabIndex = 5;
            this._labelSubtitle.Text = "Buy what you need.";
            // 
            // _labelTitle
            // 
            this._labelTitle.AutoSize = true;
            this._labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelTitle.Font = new System.Drawing.Font("SF Pro Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelTitle.Location = new System.Drawing.Point(50, 30);
            this._labelTitle.Name = "_labelTitle";
            this._labelTitle.Size = new System.Drawing.Size(115, 48);
            this._labelTitle.TabIndex = 4;
            this._labelTitle.Text = "Shop";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this._panel);
            this.Controls.Add(this._menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShopForm";
            this.Text = "Tic Tac Toe";
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this._panel.ResumeLayout(false);
            this._panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Label _labelBombs;
        private PictureBox pictureBox1;
        private Label _labelScore;
        private PictureBox pictureBox2;
        private Button _buttonBomb;
        private Label label1;
    }
}