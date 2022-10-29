namespace TicTacToe.Forms {
    partial class LoginForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this._buttonLogin = new System.Windows.Forms.Button();
            this._inputName = new TicTacToe.Controls.Input();
            this._labelName = new System.Windows.Forms.Label();
            this._labelTitle = new System.Windows.Forms.Label();
            this._inputPassword = new TicTacToe.Controls.Input();
            this._labelPassword = new System.Windows.Forms.Label();
            this._labelSubtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _buttonLogin
            // 
            this._buttonLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._buttonLogin.Location = new System.Drawing.Point(50, 349);
            this._buttonLogin.Name = "_buttonLogin";
            this._buttonLogin.Size = new System.Drawing.Size(300, 29);
            this._buttonLogin.TabIndex = 16;
            this._buttonLogin.Text = "Login";
            this._buttonLogin.UseVisualStyleBackColor = true;
            this._buttonLogin.Click += new System.EventHandler(this._buttonLogin_Click);
            // 
            // _inputName
            // 
            this._inputName.Dock = System.Windows.Forms.DockStyle.Top;
            this._inputName.Location = new System.Drawing.Point(50, 182);
            this._inputName.Name = "_inputName";
            this._inputName.Size = new System.Drawing.Size(300, 35);
            this._inputName.TabIndex = 20;
            // 
            // _labelName
            // 
            this._labelName.AutoSize = true;
            this._labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelName.Font = new System.Drawing.Font("SF Pro Rounded", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelName.ForeColor = System.Drawing.Color.Black;
            this._labelName.Location = new System.Drawing.Point(50, 104);
            this._labelName.Name = "_labelName";
            this._labelName.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this._labelName.Size = new System.Drawing.Size(74, 78);
            this._labelName.TabIndex = 19;
            this._labelName.Text = "Name";
            // 
            // _labelTitle
            // 
            this._labelTitle.AutoSize = true;
            this._labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelTitle.Font = new System.Drawing.Font("SF Pro Rounded", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelTitle.Location = new System.Drawing.Point(50, 30);
            this._labelTitle.Name = "_labelTitle";
            this._labelTitle.Size = new System.Drawing.Size(122, 48);
            this._labelTitle.TabIndex = 17;
            this._labelTitle.Text = "Login";
            // 
            // _inputPassword
            // 
            this._inputPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this._inputPassword.Location = new System.Drawing.Point(50, 265);
            this._inputPassword.Name = "_inputPassword";
            this._inputPassword.Size = new System.Drawing.Size(300, 35);
            this._inputPassword.TabIndex = 22;
            // 
            // _labelPassword
            // 
            this._labelPassword.AutoSize = true;
            this._labelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this._labelPassword.Font = new System.Drawing.Font("SF Pro Rounded", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelPassword.ForeColor = System.Drawing.Color.Black;
            this._labelPassword.Location = new System.Drawing.Point(50, 217);
            this._labelPassword.Name = "_labelPassword";
            this._labelPassword.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this._labelPassword.Size = new System.Drawing.Size(115, 48);
            this._labelPassword.TabIndex = 21;
            this._labelPassword.Text = "Password";
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
            this._labelSubtitle.Size = new System.Drawing.Size(178, 26);
            this._labelSubtitle.TabIndex = 18;
            this._labelSubtitle.Text = "Enter your credentials.";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 408);
            this.Controls.Add(this._inputPassword);
            this.Controls.Add(this._labelPassword);
            this.Controls.Add(this._inputName);
            this.Controls.Add(this._labelName);
            this.Controls.Add(this._labelSubtitle);
            this.Controls.Add(this._labelTitle);
            this.Controls.Add(this._buttonLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(50, 30, 50, 30);
            this.Text = "Tic tac toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _buttonLogin;
        private Controls.Input _inputName;
        private Label _labelName;
        private Label _labelTitle;
        private Controls.Input _inputPassword;
        private Label _labelPassword;
        private Label _labelSubtitle;
    }
}